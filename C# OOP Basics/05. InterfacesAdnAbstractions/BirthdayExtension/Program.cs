using _05._BorderControl.Models;
using _05._BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BirthdayExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IBirtdayble> colection = new List<IBirtdayble>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = data[0];

                switch (type)
                {
                    case "Citizen":
                        IBirtdayble citizen = CreateCitizen(data);
                        AddToColection(citizen, colection);
                        break;

                    case "Pet":
                        IBirtdayble pet = CreatePet(data);
                        AddToColection(pet, colection);
                        break;

                    case "Robot":
                        IBirtdayble robot = CreateRobot(data);
                        AddToColection(robot, colection);
                        break;
                }

                input = Console.ReadLine();
            }

            string searchingYear = Console.ReadLine();

            foreach (var entity in colection)
            {
                if(entity.Birthday != null && entity.Birthday.EndsWith(searchingYear))
                {
                    Console.WriteLine(entity.Birthday);
                }
            }
        }

        private static void AddToColection(IBirtdayble entity, IEnumerable<IBirtdayble> colection)
        {
            if (colection is List<IBirtdayble> tempColection)
            {
                tempColection.Add(entity);
            }
        }

        private static IBirtdayble CreatePet(string[] data)
        {
            string name = data[1];
            string birthday = data[2];
            IBirtdayble pet = new Pet(name, birthday);
            return pet;
        }

        private static IBirtdayble CreateCitizen(string[] data)
        {
            string name = data[1];
            int age = int.Parse(data[2]);
            string id = data[3];
            string birthday = data[4];

            IBirtdayble cityzen = new Citizen(id, name, age, birthday);
            return cityzen;
        }

        private static IBirtdayble CreateRobot(string[] data)
        {
            string model = data[1];
            string id = data[2];

            IBirtdayble robot = new Robot(id, model);
            return robot;
        }
    }
}
