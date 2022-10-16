using System;
using System.Linq;

namespace _13._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int nesseseryCount = int.Parse(Console.ReadLine());
            string[] words = Console.ReadLine().Split();

            foreach(var word in words)
            {
                CalculateSum(word, nesseseryCount, IsEqualToCount);
            }

        }

        static bool IsEqualToCount(int count, string word)
        {
            int sum = 0;
            word.Select(c => sum += (int)c).ToArray();
            return sum >= count;
        }

        static void CalculateSum(string word, int count, Func<int, string, bool> isEqualToCount)
        {
            if(isEqualToCount(count, word))
            {
                Console.WriteLine(word);
            }
        }
    }
}
