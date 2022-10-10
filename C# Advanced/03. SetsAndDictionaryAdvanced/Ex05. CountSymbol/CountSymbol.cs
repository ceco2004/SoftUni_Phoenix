using System;
using System.Collections.Generic;

namespace Ex05._CountSymbol
{
    class CountSymbol
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> charCount = new SortedDictionary<char, int>();

            foreach(char x in input)
            {
                if(charCount.ContainsKey(x) == false)
                {
                    charCount[x] = 0;
                }

                charCount[x]++;
            }

            foreach(var x in charCount)
            {
                Console.WriteLine($"{x.Key}: {x.Value} time/s");
            }
        }
    }
}
