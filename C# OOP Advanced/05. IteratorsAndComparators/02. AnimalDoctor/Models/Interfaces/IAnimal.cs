using System;
using System.Collections.Generic;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IAnimal : IComparable<IAnimal>
    {
        string ID { get; }
        string Name { get; }
        DateTime DateOfBirdt { get; }
        double Weight { get; }
        IOwner Owner { get; }
        IChip Chip { get; }
        IList<Diagnosis> Diagnoses { get; }

        void SetWeight(double weight);
        void SetChip(IChip chip);
        void SetOwner(IOwner owner);
        void AddDiagnosis(Diagnosis diagnosis);

    }
}
