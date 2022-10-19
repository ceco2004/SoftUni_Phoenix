using System;

namespace Ex01._PersonProblem.Models
{
    public class Person
    {
        private const string ageErrMsg = "Person's age can't be negative!";
        private const string nameErrMsg = "Person's name must be at least 3 symbols!";

        private int age;
        private string name;


        public int Age { get { return age; } set { age = CheckAge(value); } }
        public string Name { get => name; set => name = CheckName(value); }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        protected virtual string CheckName(string name)
        {
            if(name.Length < 3)
            {
                throw new ArgumentException(nameErrMsg);
            }

            return name;
        }

        protected virtual int CheckAge(int age)
        {
            if(age < 0)
            {
                throw new ArgumentException(ageErrMsg);
            }

            return age;
        }
    }
}
