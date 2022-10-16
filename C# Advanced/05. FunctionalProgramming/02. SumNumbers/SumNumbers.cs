using System;
using System.Linq;

namespace _02._SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(n => int.Parse(n))
                            .ToArray();

            string result = string.Empty;

            numbers.Length.ToString().Select(r => result += r).ToArray();
            result += Environment.NewLine;
            numbers. Sum().ToString().Select(s => result += s).ToArray();

            Console.WriteLine(result);
        }
    }
}
