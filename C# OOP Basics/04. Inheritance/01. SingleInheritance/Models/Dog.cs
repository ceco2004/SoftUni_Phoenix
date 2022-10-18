using System;
using System.Collections.Generic;
using System.Text;

namespace _01._SingleInheritance.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string owner, int age) : base(name, owner, age)
        {
        }

        
        public void Bark()
        {
            Console.WriteLine("barking...");
        }

        public int GetAge()
        {
            return base.Age;
        }
    }
}
