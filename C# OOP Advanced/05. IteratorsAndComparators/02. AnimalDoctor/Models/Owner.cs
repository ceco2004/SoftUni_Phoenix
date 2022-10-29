using _02._AnimalDoctor.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._AnimalDoctor.Models
{
    public class Owner : IOwner
    {
        private const string WrongNameErr =  "The names must be minimum 3 letters, and start with uppercase!";
        private const string WrongPhoneErr = "Phone number must contain only digits!";



        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public string Address { get; private set; }

        public IList<IAnimal> Animals { get; private set; }

        public Owner(string firstName, string lastName, string phone, string email = "", string address = "")
        {
            FirstName = CheckTheNames(firstName);
            LastName = CheckTheNames(lastName);
            Phone = CheckPhone(phone);

            Animals = new List<IAnimal>();
        }

        private string CheckPhone(string phone)
        {
            bool areAllDigits = true;
            foreach(char ch in phone)
            {
                if(char.IsDigit(ch) == false)
                {
                    areAllDigits = false;
                    break;
                }
            }

            if(areAllDigits == false)
            {
                throw new AggregateException(WrongPhoneErr);
            }

            return phone;
        }

        private string CheckTheNames(string name)
        {
            bool isStartWithUpper = char.IsUpper(name[0]);
            bool isMinimumTreeSymbols = name.Length >= 3;

            if(!(isStartWithUpper && isMinimumTreeSymbols))
            {
                throw new ArgumentException(WrongNameErr);
            }

            return name;
        }


        public bool AddAnimal(IAnimal animal)
        {
            bool success = false;
            Animals.Add(animal);
            if (Animals.Contains(animal))
            {
                success = true;
            }
            return success;
        }

        public bool ChangeEmail(string email)
        {
            Email = email;
            return true;
        }

        public bool ChangePhone(string phone)
        {
            Phone = CheckPhone(phone);
            return true;
        }

        public IAnimal RemoveAnimal(IAnimal animal)
        {
            if (Animals.Contains(animal))
            {
                Animals.Remove(animal);
            }
            return animal;
        }

        public override string ToString()
        {
            char one = '.';
            char two = ':';
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{FirstName} {LastName} is owner an {Animals.Count} animal's{(Animals.Count == 0 ? one : two)}");
            foreach(IAnimal animal in Animals)
            {
                sb.AppendLine($"{animal.Name} has born on {animal.DateOfBirdt.Year} and have owner {animal.Owner.FirstName} {animal.Owner.LastName}");
            }
            return sb.ToString();
        }
    }
}
