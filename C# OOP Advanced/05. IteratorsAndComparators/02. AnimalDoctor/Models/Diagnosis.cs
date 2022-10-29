using _02._AnimalDoctor.Models.Interfaces;
using System;

namespace _02._AnimalDoctor.Models
{
    public class Diagnosis : IDiagnosis
    {
        public DateTime DateOfDiagnose { get; private set; }

        public string Description { get; private set; }

        public IAnimal Animal { get; private set; }

        public IRecipe Recipe { get; private set; }

        public Diagnosis(IAnimal animal)
        {
            Animal = animal;
            DateOfDiagnose = DateTime.Now;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void SetRecipe(IRecipe recipe)
        {
            Recipe = recipe;
        }

    }
}
