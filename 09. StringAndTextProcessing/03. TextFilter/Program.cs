using System;
using System.Linq;

namespace _03._TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").Select(w => w.Trim()).ToArray();
            string text = Console.ReadLine();

            foreach(string word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
