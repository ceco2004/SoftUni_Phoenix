using Ex10._CarSalesMan.Models;
using System;
using System.Collections.Generic;

namespace Ex10._CarSalesMan
{
    internal class CarSalesMan
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());

            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for(int i = 0; i < engineCount; i++)
            {
                AddEngine(engines);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for(int i = 0; i < carsCount; i++)
            {
                AddCar(engines, cars);
            }

            PrintCars(cars);
        }

        private static void PrintCars(List<Car> cars)
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static void AddCar(Dictionary<string, Engine> engines, List<Car> cars)
        {
            string[] input = ReadData();
            string model = input[0];
            string engineModel = input[1];

            if(engines.ContainsKey(engineModel) == false)
            {
                return;
            }

            int weight = 0;
            string color = string.Empty;

            if(input.Length > 2)
            {
                if (int.TryParse(input[2], out weight))
                {
                    if(input.Length == 4)
                    {
                        color = input[3];
                    }
                }
            }

            Car car = new Car()
            {
                 Model = model,
                 Engine = engines[engineModel],
                 Color = color,
                 Weight = weight
            };

            cars.Add(car);
            
        }

        private static void AddEngine(Dictionary<string, Engine> engines)
        {
            string[] input = ReadData();
            string model = input[0];

            if (engines.ContainsKey(model))
            {
                return;
            }

            int power = int.Parse(input[1]);
            int displacement = -0;
            string effecient = string.Empty;

            if (input.Length > 2)
            {
                if (int.TryParse(input[2], out displacement))
                {
                    if (input.Length == 4)
                    {
                        effecient = input[3];
                    }
                }
                else
                {
                    effecient = input[2];
                }
            }

            Engine e = new Engine()
            {
                Model = model,
                Power = power,
                Efficiency = effecient,
                Displacement = displacement
            };

            engines[model] = e;
        }

        private static string[] ReadData()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
