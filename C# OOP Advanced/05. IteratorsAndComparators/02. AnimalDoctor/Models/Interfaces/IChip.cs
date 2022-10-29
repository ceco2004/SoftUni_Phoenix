using System;
using System.Collections.Generic;
using System.Text;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IChip
    {
        bool IsAvailable { get; }
        DateTime DateOfInstall { get; }
        string SerialNumber { get; }
        IAnimal Animal { get; }

        string InstallChip(string serialNumber);
        string RemoveChip(string serialNumber);
        string UpdateChip(string serialNumber_OLD, string serialNumber_NEW);
    }
}
