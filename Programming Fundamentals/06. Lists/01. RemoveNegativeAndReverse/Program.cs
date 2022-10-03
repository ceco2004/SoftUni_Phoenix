using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            nums = nums.Where(x => x > 0).ToList();

            if (nums.Count > 0)
            {
                nums.Reverse();
                Console.WriteLine(string.Join(' ', nums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
