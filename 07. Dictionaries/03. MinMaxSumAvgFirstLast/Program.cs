using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MinMaxSumAvgFirstLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for(int i  = 0; i < count; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Min = {nums.Max()}");
            Console.WriteLine($"Average =  {nums.Average()}");
        }
    }
}
