using _02._AnimalDoctor.Models;
using _02._AnimalDoctor.Models.Interfaces;
using System;
using Newtonsoft.Json;

namespace _02._AnimalDoctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            Cat cat = new Cat("003","Pufi", "01/10/2019");
            Dog dog = new Dog("001", "Bark", "01/10/2020");

            Animal[] animals = new Animal[] { cat, dog };
          
            string animalsAsText = JsonConvert.SerializeObject(animals);
            Console.WriteLine(animalsAsText);
            
           // var animalsFromText = JsonConvert.DeserializeObject<Animal[]>(animalsAsText);

           

            Console.WriteLine();

            //IAnimal myCat = clinic.GetAnimal("002");
            //Console.WriteLine(cat);
            //IChip chip = new Chip();
            //chip.InstallChip("001", cat);
            //cat.SetChip(chip);

            //IOwner ceco = new Owner("Ceco", "Rad", "08545");
            //ceco.AddAnimal(cat);
            //cat.SetOwner(ceco);
            //Console.WriteLine();
            //Console.WriteLine(cat);
            //Console.WriteLine(ceco);

            
        }
    }
}
