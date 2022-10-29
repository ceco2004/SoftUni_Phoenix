namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IRecipe
    {
        IDiagnosis Diagnosis { get; }
        string RecipeDescription { get; }

        void SetDescription(string descripton);
    }
}
