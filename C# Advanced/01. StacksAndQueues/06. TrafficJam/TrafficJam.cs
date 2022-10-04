using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int pass = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            List<string> passedCars = new List<string>();
            string input = Console.ReadLine();

            while(input != "end")
            {
                if(input == "green")
                {
                    for(int i = 0; i < pass; i++)
                    {
                        if(cars.Count > 0)
                        {
                            passedCars.Add(cars.Dequeue());
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", passedCars.Select(c => $"{c} passed!")));
            Console.WriteLine($"{passedCars.Count} cars passed the crossroad");
        }
    }
}
