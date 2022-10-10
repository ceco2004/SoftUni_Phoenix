using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountSomeValuesInArray
{
    class CountSomeValuesInArray
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(x => int.Parse(x))
                         .ToArray();
            Dictionary<int, int> numCounter = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if(numCounter.ContainsKey(num) == false)
                {
                    numCounter[num] = 0;
                }

                numCounter[num]++;
            }

            foreach(var kvp in numCounter)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
