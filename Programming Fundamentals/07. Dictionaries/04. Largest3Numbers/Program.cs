using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            nums = nums.OrderBy(x => -x).ToList();
            Console.WriteLine(string.Join(" ", nums.Take(3)));
        }
    }
}
