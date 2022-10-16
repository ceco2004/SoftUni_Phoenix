using System;

namespace _01._SortByNameAndAge.Models
{
    public class Person
    {
        private const string shotNameErrMsg = "Name cannot contain less than 3 symbols!";
        private const string ageErrMsg = "Age cannot be zero or a negative integer!";
        private const string salaryErrMsg = "Salary cannot be less than 760 leva!";
        private const string bonusErrMsg = "The bonus mus be between 1 and 100 %";

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { get => firstName; private set => firstName = CheckName(value); }
        public string LastName { get => lastName; private set => lastName = CheckName(value); }
        public int Age { get => age; private set => age = CheckAge(value); }
        public decimal Salary { get => salary; private set => salary = CheckSalary(value); }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName, int age, decimal salary)
                        :this(firstName, lastName, age)
        {
            Salary = salary;
        }

        private decimal CheckSalary(decimal salary)
        {
            if(salary < 760)
            {
                throw new ArgumentException(salaryErrMsg);
            }

            return salary;
        }

        private int CheckAge(int age)
        {
            if(age <= 0)
            {
                throw new ArgumentException(ageErrMsg);
            }

            return age;
        }

        private string CheckName(string name)
        {
            if(name.Length < 3)
            {
                throw new ArgumentException(shotNameErrMsg);
            }

            return name;
        }

        public void	IncreaseSalary(decimal percent)
        {
            if(percent < 1 || percent > 99)
            {
                throw new ArgumentException(bonusErrMsg);
            }


            if(Age < 30)
            {
                percent = percent / 2;
            }

            Salary += Salary * percent / 100;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} recives {Salary:f2} leva.";
        }
    }
}
