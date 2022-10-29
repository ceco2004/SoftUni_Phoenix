using System;
using System.Collections.Generic;
using System.Text;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        DateTime DateOfBirdt { get; }
        double Weith { get; }
        IOwner Owner { get; }
        IChip Chip { get; }

    }
}
