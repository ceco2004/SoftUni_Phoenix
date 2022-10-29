using _02._AnimalDoctor.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace _02._AnimalDoctor.Models
{
    public abstract class Animal : IAnimal
    {
        public string ID { get; }

        public string Name { get; private set; }

        public DateTime DateOfBirdt { get; private set; }

        public double Weight { get; private set; }

        public IOwner Owner { get; private set; }

        public IChip Chip { get; private set; }

        public IList<Diagnosis> Diagnoses { get; private set; }

        public Animal(string ID, string name, string dateOfBirdt, IOwner owner = null)
        {
            this.ID = ID;
            Name = name;
            Owner = owner;
            DateOfBirdt = ConvertToDate(dateOfBirdt);
            Diagnoses = new List<Diagnosis>();
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }

        public void SetChip(IChip chip)
        {
            Chip = chip;
        }

        public void SetOwner(IOwner owner)
        {
            Owner = owner;
        }


        public void AddDiagnosis(Diagnosis diagnosis)
        {
            Diagnoses.Add(diagnosis);
        }

        private DateTime ConvertToDate(string dateOfBitrdt)
        {
            return DateTime.ParseExact(dateOfBitrdt, "dd/MM/yyyy", new CultureInfo("bg-BG"));
        }


        public override string ToString()
        {
            string aditional = string.Empty;
            if(Owner != null)
            {
                aditional = $" and have owner {Owner.FirstName} {Owner.LastName}";
            }
            else
            {
                aditional = " and havn't owner yet.";
            }

            string chipMsg = string.Empty;
            if(Chip != null)
            {
                chipMsg = $"I have chip with number {Chip.SerialNumber}.";
            }
            else
            {
                chipMsg = "I hav't chip yet.";
            }
            return $"{Name} has born on {DateOfBirdt.Year}{aditional}\n{chipMsg}";
        }

        public int CompareTo([AllowNull] IAnimal other)
        {
            return DateOfBirdt.Year.CompareTo(other.DateOfBirdt.Year);
        }

    }
}
