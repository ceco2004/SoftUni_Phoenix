using System;
using System.Text;

namespace Ex03._Mankind.Models
{
    public abstract class Human
    {
        private const string missingTwoNamesErr = "Expected First and Last names!";
        private const string missingCapitalLetterErr = "Expected upper case letter! Argument: Name";
        private const string shortNameErr = "Expected length at least 3 symbols! Argument: Name ";

        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = ValidateName(value); }
        public string LastName { get => lastName; set => lastName = ValidateName(value); }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {FirstName}");
            sb.AppendLine($"Last Name: {LastName}");

            return sb.ToString();
        }

        private string ValidateName(string name)
        {
            if (char.IsUpper(name[0]) == false)
            {
                throw new ArgumentException(missingCapitalLetterErr);
            }

            if (name.Length < 3)
            {
                throw new ArgumentException(shortNameErr);
            }
            return name;
        }
    }
}
