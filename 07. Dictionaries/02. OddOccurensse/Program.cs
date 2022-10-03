using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurensse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach(string word in input)
            {
                if(wordsCount.ContainsKey(word) == false)
                {
                    wordsCount.Add(word, 0);
                }
                wordsCount[word]++;
            }

            Console.WriteLine(string.Join(", ", wordsCount.Where(w => w.Value % 2 != 0).Select(x => x.Key)));
        }
    }
}
