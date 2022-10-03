using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._ShortWordSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {'.',',',',',':',';','(',')','[',']',' ', '"','\\','/','!',',',',','?'};
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToList();

            Console.WriteLine(string.Join(", ", words.Distinct().Where(w => w.Length < 5).OrderBy(w=> w)));

        }
    }
}
