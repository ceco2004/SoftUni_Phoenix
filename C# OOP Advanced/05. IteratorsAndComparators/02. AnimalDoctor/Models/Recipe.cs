using _02._AnimalDoctor.Models.Interfaces;

namespace _02._AnimalDoctor.Models
{
    public class Recipe : IRecipe
    {
        public IDiagnosis Diagnosis { get; private set; }

        public string RecipeDescription { get; private set; }

        public Recipe(IDiagnosis diagnosis)
        {
            Diagnosis = diagnosis;
        }

        public void SetDescription(string descripton)
        {
            RecipeDescription = descripton;
        }
    }
}
