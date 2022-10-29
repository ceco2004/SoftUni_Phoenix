using _02._AnimalDoctor.Models.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._AnimalDoctor.Models
{
    public class Clinic : IEnumerable<IAnimal>
    {
        private readonly List<IAnimal> animals;
        public IReadOnlyList<IAnimal> Animals { get => animals; }

        public Clinic()
        {
            animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(IAnimal animal)
        {
            animals.Remove(animal);
        }

        public IAnimal GetAnimal(string ID)
        {
            var colection = animals.Where(a => a.ID == ID).ToArray();
            if(colection.Length == 1)
            {
                return colection[0];
            }
            return null;
        }

        public IEnumerator<IAnimal> GetEnumerator()
        {
            return ClinicEnumerator.GetClinicEnumerator(animals);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
            
        }

        private static class ClinicEnumerator
        {
            public static IEnumerator<IAnimal> GetClinicEnumerator(IList<IAnimal> animals)
            {
                for(int i = 0; i < animals.Count; i++)
                {
                    yield return animals[i];
                }
            }
        }
    }
}
