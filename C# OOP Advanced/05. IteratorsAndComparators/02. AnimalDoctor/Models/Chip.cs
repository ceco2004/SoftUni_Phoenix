using _02._AnimalDoctor.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._AnimalDoctor.Models
{
    public class Chip : IChip
    {
        public bool IsAvailable { get; private set; }

        public DateTime DateOfInstall { get; private set; }

        public string SerialNumber { get; private set; }

        public IAnimal Animal { get; private set; }


        public Chip()
        {
            IsAvailable = false;
        }

        public void InstallChip(string serialNumber, IAnimal animal)
        {
            Animal = animal;
            UpdateChip(serialNumber);
        }

        public void RemoveChip(string serialNumber)
        {
            IsAvailable = false;
        }

        public void UpdateChip(string serialNumber_NEW)
        {
            SerialNumber = serialNumber_NEW;
            DateOfInstall = DateTime.Now;
        }
    }
}
