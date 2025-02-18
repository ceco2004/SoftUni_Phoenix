﻿using _03._Person.Models;
using _03._Person.Models.Interfaces;
using System;

namespace _03._Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);


        }
    }
}
