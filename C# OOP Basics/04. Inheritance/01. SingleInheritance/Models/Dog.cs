using System;
using System.Collections.Generic;
using System.Text;

namespace _01._SingleInheritance.Models
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
