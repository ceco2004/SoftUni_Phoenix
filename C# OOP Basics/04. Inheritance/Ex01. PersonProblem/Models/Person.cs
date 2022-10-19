using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01._PersonProblem.Models
{
    public class Person
    {
        private const string ageErrMsg = "Age can't be negative!";

        private int age;


        public int Age { get { return age; } set { age = CheckAge(value); } }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
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
