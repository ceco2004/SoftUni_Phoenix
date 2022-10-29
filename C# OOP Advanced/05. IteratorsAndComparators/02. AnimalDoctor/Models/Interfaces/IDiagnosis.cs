using System;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IDiagnosis
    {
        DateTime DateOfDiagnose { get; }
        string Description { get; }
        IAnimal Animal { get; }
        IRecipe Recipe { get; }

        void SetDescription(string description);
        void SetRecipe(IRecipe recipe);
    }
}
