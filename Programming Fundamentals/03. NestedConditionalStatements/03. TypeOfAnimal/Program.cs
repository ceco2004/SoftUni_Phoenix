using System;

namespace _03._TypeOfAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string typeOfAnimal = string.Empty;

            switch (animal)
            {
                case "dog":
                    typeOfAnimal = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    typeOfAnimal = "reptile";
                    break;
                default:
                    typeOfAnimal = "unknown";
                    break;
            }
            Console.WriteLine(typeOfAnimal);
    }
    }
}
