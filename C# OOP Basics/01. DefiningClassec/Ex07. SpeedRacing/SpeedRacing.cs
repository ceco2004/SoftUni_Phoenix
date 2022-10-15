using System;
using System.Collections.Generic;

namespace Ex07._SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int carCount = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for(int i = 0; i < carCount; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];

                if (cars.ContainsKey(model))
                {
                    continue;
                }

                double fuelAmount = double.Parse(data[1]);
                double conumption = double.Parse(data[2]);

                Car car = new Car(model, fuelAmount, conumption);
                cars[model] = car;
            }

            string input = Console.ReadLine();

            while(input != "End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                
                if(command == "Drive")
                {
                    string model = data[1];

                    if (cars.ContainsKey(model))
                    {
                        int distanceToMove = int.Parse(data[2]);
                        string msg = cars[model].MoveCar(distanceToMove);
                        Console.WriteLine(msg);
                    }
                }

                input = Console.ReadLine();
            }

            foreach(var pair in cars)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
