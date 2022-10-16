using System;
using System.Linq;

namespace _04._AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(n => double.Parse(n))
                            .ToArray();

            string[] numsWithVAT = nums
                                   .Select(n => n += n * 20 / 100)
                                   .Select(n => $"{n:f2}")
                                   .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, numsWithVAT));
        }
    }
}
