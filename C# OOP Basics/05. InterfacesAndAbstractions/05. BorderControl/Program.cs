using _05._BorderControl.Models;
using _05._BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace _05._BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ITrackable> colection = new List<ITrackable>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (data.Length == 2)
                {
                    ITrackable robot = CreateRobot(data);
                    AddToColection(robot, colection);
                }
                else if (data.Length == 3)
                {
                    ITrackable citizen = CreateCitizen(data);
                    AddToColection(citizen, colection);
                }

                input = Console.ReadLine();
            }

            string searchingEnd = Console.ReadLine();

            foreach(var entity in colection)
            {
                if (entity.Id.EndsWith(searchingEnd))
                {
                    Console.WriteLine(entity.Id);
                }
            }
        }

        private static void AddToColection(ITrackable entity, IEnumerable<ITrackable> colection)
        {
            if(colection is List<ITrackable> tempColection)
            {
                tempColection.Add(entity);
            }
        }

        private static ITrackable CreateCitizen(string[] data)
        {
            string name = data[0];
            int age = int.Parse(data[1]);
            string id = data[2];

            ITrackable cityzen = new Citizen(id, name, age);
            return cityzen;
        }

        private static ITrackable CreateRobot(string[] data)
        {
            string model = data[0];
            string id = data[1];

            ITrackable robot = new Robot(id, model);
            return robot;
        }
    }
}
