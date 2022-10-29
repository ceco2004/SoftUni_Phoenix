using System;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IAnimal : IComparable<IAnimal>
    {
        string Name { get; }
        DateTime DateOfBirdt { get; }
        double Weight { get; }
        IOwner Owner { get; }
        IChip Chip { get; }

    }
}
