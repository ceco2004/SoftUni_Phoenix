﻿using _03._Person.Models.Interfaces;

namespace _03._Person.Models
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }


        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
