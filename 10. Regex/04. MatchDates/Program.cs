using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string datePattern = @"\b([0-9]{2})(\.|-|\/)([A-Z][a-z]{2})\2([0-9]{4})\b";

            Regex rx = new Regex(datePattern);

            foreach(string date in input)
            {
                Match match = rx.Match(date);
                if (match.Success)
                {
                    string day = match.Groups[1].Value;
                    string month = match.Groups[3].Value;
                    string year = match.Groups[4].Value;

                    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
                }
            }
        }
    }
}
