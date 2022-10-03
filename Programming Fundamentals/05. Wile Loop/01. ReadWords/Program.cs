using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._ReadWords
{
    class Program
    {
        static string input = string.Empty;
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Input();

            while (input != "Stop")
            {
                words.Add(input);
                Input();
            }

            PrintList(words);
        }

        static void PrintList(List<string> words)
        {
            foreach(string name in words)
            {
                Console.WriteLine(name);
            }
        }

        static void Input()
        {
            input = Console.ReadLine();
        }
    }
}
