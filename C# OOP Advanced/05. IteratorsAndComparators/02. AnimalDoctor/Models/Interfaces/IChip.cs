using System;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IChip
    {
        bool IsAvailable { get; }
        DateTime DateOfInstall { get; }
        string SerialNumber { get; }
        IAnimal Animal { get; }

        void InstallChip(string serialNumber, IAnimal animal);
        void RemoveChip(string serialNumber);
        void UpdateChip(string serialNumber_NEW);
    }
}
