using System;
using System.Collections.Generic;

namespace _06._ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            CollectData(cars);

            PrintCars(cars);
           
        }

        private static void PrintCars(HashSet<string> cars)
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join("\n", cars));
            }
        }

        private static void CollectData(HashSet<string> cars)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = data[0];
                string car = data[1];

                switch (direction)
                {
                    case "IN":
                        cars.Add(car);
                        break;
                    case "OUT":
                        cars.Remove(car);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
