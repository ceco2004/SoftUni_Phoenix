using System;
using System.Linq;

namespace _08._CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int sum = CondenseArrayToNumber(numbers);

            Console.WriteLine(sum);
        }

        static int CondenseArrayToNumber(int[] numbers)
        {
            while(numbers.Length > 1)
            {
                int[] temp = new int[numbers.Length - 1];

                for(int i = 0; i < numbers.Length - 1; i++)
                {
                    temp[i] = numbers[i] + numbers[i + 1];
                }

                numbers = temp;
            }

            return numbers[0];
        }
    }
}
