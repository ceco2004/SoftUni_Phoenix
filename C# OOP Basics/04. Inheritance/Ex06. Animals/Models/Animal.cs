using Ex06._Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06._Animals.Models
{
    public abstract class Animal : ISoundProducable
    {
        private int age;

        public string Name { get; set; }
        public int Age { get => age; set => age = CheckAge(value); }
        public Gender Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = GenerateGender(gender);
        }

        private Gender GenerateGender(string gender)
        {
            if(gender == "Male")
            {
                return Gender.Male;
            }

            return Gender.Female;

        }

        private int CheckAge(int age)
        {
            if(age <= 0)
            {
                throw new ArgumentException("Invalid age!");
            }
            return age;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine($"{ProduceSound()}");
            return sb.ToString();
        }

    }
}
