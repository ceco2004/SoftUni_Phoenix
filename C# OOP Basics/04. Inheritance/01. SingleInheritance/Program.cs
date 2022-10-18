using _01._SingleInheritance.Models;
using System;

namespace _01._SingleInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bark", "Ivan", 5);
            Console.WriteLine(dog.GetAge());
            dog.Eat();
            dog.Bark();

            Puppy puppy = new Puppy("Pupy", "Malcho", 1);
            puppy.Weep();
            

            Cat cat = new Cat("Pufi", "Ceco", 3);
            cat.Meow();


            Animal animal = new Animal("Pufi", "Ceco", 3);

            var castedAnimal = puppy as Dog;
            if(castedAnimal != null)
            {
                castedAnimal.Bark();
            }
        }
    }
}
