using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

            Dictionary<double, int> counted = new Dictionary<double, int>();

            foreach (double num in nums)
            {
                if (counted.ContainsKey(num) == false)
                {
                    counted[num] = 0;
                }
                counted[num]++;
            }

            foreach (var pair in counted.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Value} times -> number: {pair.Key}");
            }

        }
    }
}
