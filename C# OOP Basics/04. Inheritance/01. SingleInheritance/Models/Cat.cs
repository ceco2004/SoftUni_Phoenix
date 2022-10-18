using System;
using System.Collections.Generic;
using System.Text;

namespace _01._SingleInheritance.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string owner, int age) : base(name, owner, age)
        {
        }

        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }
}
