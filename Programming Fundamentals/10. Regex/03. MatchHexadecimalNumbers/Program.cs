using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(0x)?[0-9]*[A-F]*\b";

            Regex rx = new Regex(pattern);

            string[] matches = rx.Matches(input)
                               .Select(m => m.Value)
                               .Where(r => r != string.Empty)
                               .ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
