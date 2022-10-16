using System;
using System.Linq;

namespace _01._SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(n => int.Parse(n))
                            .ToArray();

            int[] evenSortedNumbers = numbers
                                      .Where(n => n % 2 == 0)
                                      .OrderBy(n => n)
                                      .ToArray();

            Console.WriteLine(string.Join(", ", evenSortedNumbers));
        }
    }
}
