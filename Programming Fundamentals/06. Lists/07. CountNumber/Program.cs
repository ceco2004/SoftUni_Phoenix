using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Array.Sort(numbers);

            List<string> result = new List<string>();

            int count = 1;
            int currentNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == currentNum)
                {
                    count++;
                }
                else
                {
                    result.Add($"{currentNum} -> {count}");
                    currentNum = numbers[i];
                    count = 1;
                }

                if(i == numbers.Length - 1)
                {
                    result.Add($"{currentNum} -> {count}");

                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
