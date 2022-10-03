using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]+) [A-Z][a-z]+\b";
            Regex rx = new Regex(pattern);

            MatchCollection matches = rx.Matches(names);
            List<string> allNames = new List<string>();
            foreach(Match match in matches)
            {
                string name = match.Groups[0].Value;
                allNames.Add(name);
            }

            Console.WriteLine(string.Join(" ", allNames));
        }
    }
}
