using System;
using System.Collections.Generic;

namespace Ex06._Warderobe
{
    class Warderobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colorDress
                = new Dictionary<string, Dictionary<string, int>>();

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(" -> ");
                string color = data[0];
                string[] dress = data[1].Split(",");

                if(colorDress.ContainsKey(color) == false)
                {
                    colorDress[color] = new Dictionary<string, int>();
                }

                foreach(var item in dress)
                {
                    if (colorDress[color].ContainsKey(item) == false)
                    {
                        colorDress[color][item] = 0;
                    }

                    colorDress[color][item]++;

                }

            }

            string[] searched = Console.ReadLine().Split(" ");
            string sColor = searched[0];
            string sDress = searched[1];

            foreach(var kvp in colorDress)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach(var item in kvp.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if(kvp.Key == sColor && item.Key == sDress)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
