using _02._AnimalDoctor.Models.Interfaces;
using System;

namespace _02._AnimalDoctor.Models
{
    public class Animal : IAnimal
    {
        public string Name { get; private set; }

        public DateTime DateOfBirdt { get; private set; }

        public double Weith { get; private set; }

        public IOwner Owner { get; private set; }

        public IChip Chip { get; private set; }
    }
}
