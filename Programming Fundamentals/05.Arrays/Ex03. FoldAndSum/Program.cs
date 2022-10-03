using System;
using System.Linq;

namespace Ex03._FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();


            int[] revercedRoll = TakeRevercedNumbers(numbers);
            int[] normalRoll = TakeMiddlePart(numbers);

            for(int i = 0; i < revercedRoll.Length; i++)
            {
                Console.Write($"{revercedRoll[i] + normalRoll[i]} ");
            }

            Console.WriteLine();
        }

        static int[] TakeMiddlePart(int[] numbers)
        {
            int k = numbers.Length / 4;
            int[] normalRoll = new int[numbers.Length / 2];

            for(int i = k; i < numbers.Length - k; i++)
            {
                normalRoll[i - k] = numbers[i];
            }

            return normalRoll;
        }

        static int[] TakeRevercedNumbers(int[] numbers)
        {
            int k = numbers.Length / 4;
            int[] revercedRoll = new int[numbers.Length / 2];

            //Take first K
            int count = 0;
            for(int i = k-1; i >= 0; i--)
            {
                revercedRoll[count++] = numbers[i];
            }

            //Take last K
            count = k;
            for(int i = numbers.Length - 1; i > numbers.Length - 1 - k; i--)
            {
                revercedRoll[count++] = numbers[i];
            }

            return revercedRoll;
        }
    }
}
