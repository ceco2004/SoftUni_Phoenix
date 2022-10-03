using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";

            Regex rx = new Regex(pattern);

            string[] numbers = rx.Matches(input)
                                    .Select(m => m.Groups[0].Value)
                                    .ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
