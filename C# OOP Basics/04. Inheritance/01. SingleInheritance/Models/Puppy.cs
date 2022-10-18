using System;
using System.Collections.Generic;
using System.Text;

namespace _01._SingleInheritance.Models
{
    public class Puppy : Dog
    {
        public Puppy(string name, string owner, int age) : base(name, owner, age)
        {
        }

        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
}
