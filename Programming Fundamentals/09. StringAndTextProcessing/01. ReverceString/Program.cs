using System;
using System.Linq;

namespace _01._ReverceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = new string(input.Reverse().ToArray());
            Console.WriteLine(input);
        }
    }
}
