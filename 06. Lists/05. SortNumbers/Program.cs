using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToList();
            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
