using System;
using System.Linq;

namespace _04._TrippleSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            bool haveMatches = false;

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i+1; j < numbers.Length; j++)
                {
                    for(int k = 0; k < numbers.Length; k++)
                    {
                        if(numbers[i] + numbers[j] == numbers[k])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            haveMatches = true;
                        }
                    }
                }
            }

            if (!haveMatches)
            {
                Console.WriteLine("No");
            }
        }
    }
}
