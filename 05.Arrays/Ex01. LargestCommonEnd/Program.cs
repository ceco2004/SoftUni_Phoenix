using System;
using System.Linq;

namespace Ex01._LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string[] words2 = Console.ReadLine().Split().ToArray();

           int countNormal = CheckNormalWay(words, words2);

            Array.Reverse(words);
            Array.Reverse(words2);

            int couuntBack = CheckNormalWay(words, words2);

            Console.WriteLine( Math.Max(countNormal, couuntBack));
        }

        static int CheckNormalWay(string[] words, string[] words2)
        {
            int count = 0;
            for(int i = 0; i < Math.Min(words.Length, words2.Length); i++)
            {
                if (words[i] == words2[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
