using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindroms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split("?!., ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> palindroms = new List<string>();
            foreach(string word in words)
            {
                if (IsPalindrom(word))
                {
                    palindroms.Add(word);
                }
            }

            palindroms = palindroms.Distinct().OrderBy(w => w).ToList();

            Console.WriteLine(string.Join(", ", palindroms));
        }

        static bool IsPalindrom(string word)
        {
            bool isPalindrom = true;
            for(int i = 0; i <= word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            return isPalindrom;
        }
    }
}
