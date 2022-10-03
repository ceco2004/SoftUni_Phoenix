using System;
using System.IO;
using System.Linq;

namespace _01._OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");

            string[] oddLines = text.Where((l, i) => i % 2 == 1).ToArray();

            File.WriteAllLines("output.txt", oddLines);
        }
    }
}
