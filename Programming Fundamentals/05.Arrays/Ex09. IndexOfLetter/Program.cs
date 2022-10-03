using System;

namespace Ex09._IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            foreach(char ch in input)
            {
                Console.WriteLine($"{ch} -> {(int)ch -97}");
            }
        }
    }
}
