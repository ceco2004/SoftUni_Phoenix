using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01._PersonProblem.Models
{
    public class Child : Person
    {
        private const string childAgeErrMsg = "Child age can't be more than 15 Years!";

        public Child(string name, int age): base(name, age)
        {
        }

        protected override int CheckAge(int age)
        {
            if(age > 15)
            {
                throw new ArgumentException(childAgeErrMsg);
            }
            return age;
        }
    }
}
