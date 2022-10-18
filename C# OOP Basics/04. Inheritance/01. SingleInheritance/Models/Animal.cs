using System;
using System.Collections.Generic;
using System.Text;

namespace _01._SingleInheritance.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public int Age { get; set; }

        public Animal(string name, string owner, int age)
        {
            Name = name;
            Owner = owner;
            Age = age;
        }


        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
}
