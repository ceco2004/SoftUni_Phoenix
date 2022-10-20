using Ex06._Animals.Interfaces;
using Ex06._Animals.Models;
using System;
using System.Collections.Generic;

namespace Ex06._Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISoundProducable> animals = new List<ISoundProducable>();

            string animalType = Console.ReadLine();

            while(animalType != "Beast!")
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                ISoundProducable animal = null;

                try
                {
                    switch (animalType)
                    {
                        case "Cat":
                            animal = ProduceCat(data);
                            break;
                        case "Kitten":
                            animal = ProduceKitten(data);
                            break;
                        case "Tomcat":
                            animal = ProduceTomcat(data);
                            break;
                        case "Dog":
                            animal = ProduceDog(data);
                            break;
                        case "Frog":
                            animal = ProduceFrog(data);
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (animal != null)
                {
                    animals.Add(animal);
                }

                animalType = Console.ReadLine();
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static ISoundProducable ProduceKitten(string[] data)
        {
            if (data.Length < 2 || data.Length > 3)
            {
                return null;
            }

            return new Kitten(data[0], int.Parse(data[1]));
        }

        private static ISoundProducable ProduceTomcat(string[] data)
        {
            if (data.Length < 2 || data.Length > 3)
            {
                return null;
            }

            return new Tomcat(data[0], int.Parse(data[1]));
        }

        private static ISoundProducable ProduceFrog(string[] data)
        {
            if (data.Length != 3)
            {
                return null;
            }

            return new Frog(data[0], int.Parse(data[1]), data[2]);
        }

        private static ISoundProducable ProduceDog(string[] data)
        {
            if (data.Length != 3)
            {
                return null;
            }

            return new Dog(data[0], int.Parse(data[1]), data[2]);
        }

        private static ISoundProducable ProduceCat(string[] data)
        {
            if(data.Length != 3)
            {
                return null;
            }

            return new Cat(data[0], int.Parse(data[1]), data[2]);
        }
    }
}
