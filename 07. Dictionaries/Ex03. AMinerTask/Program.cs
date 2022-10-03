using System;
using System.Collections.Generic;

namespace Ex03._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> collection = new Dictionary<string, int>();

            while(input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if(collection.ContainsKey(input) == false)
                {
                    collection[input] = quantity;
                }
                else
                {
                    collection[input] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach(var item in collection)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
