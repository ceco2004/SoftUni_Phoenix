using System;

namespace Ex01._PersonProblem.Models
{
    public class Child : Person
    {
        private const string childAgeErrMsg = "Child's age can't be more than 15 Years!";
        private const string nameErrMsg = "Child's name must be at least 3 symbols!";

        public Child(string name, int age) : base(name, age)
        {
        }

        protected override string CheckName(string name)
        {
            if(name.Length < 3)
            {
                throw new ArgumentException(nameErrMsg);
            }

            return name;
        }

        protected override int CheckAge(int age)
        {
            if(age > 15)
            {
                throw new ArgumentException(childAgeErrMsg);
            }
            return base.CheckAge(age);
        }
    }
}
