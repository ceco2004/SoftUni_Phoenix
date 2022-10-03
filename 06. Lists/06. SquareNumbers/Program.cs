using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToList();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if(Math.Sqrt(numbers[i]) - (int)Math.Sqrt(numbers[i]) != 0){
                    numbers.RemoveAt(i);
                }
            }

            numbers.Sort();
            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
