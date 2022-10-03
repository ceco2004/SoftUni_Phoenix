using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', ':', ';', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixed = new List<string>();

            foreach (string word in words)
            {
                switch (SenseTheCase(word))
                {
                    case "upper": upperCase.Add(word); break;
                    case "lower": lowerCase.Add(word); break;
                    case "mixed": mixed.Add(word); break;
                }
            }

            string msg = string.Empty;
            msg = $"Lower-case: {string.Join(", ", lowerCase)}";
            msg += $"\nMixed-case: {string.Join(", ", mixed)}";
            msg += $"\nUpper-case: {string.Join(", ", upperCase)}";

            Console.WriteLine(msg);
        }

        static string SenseTheCase(string word)
        {
            bool isUpper = false;
            bool isLower = false;
            string result = string.Empty;

            foreach (char ch in word)
            {
                if (char.IsDigit(ch) || (isLower && isUpper))
                {
                    result = "mixed";
                    break;
                }
                else if (char.IsUpper(ch))
                {
                    isUpper = true;
                }
                else if (char.IsLower(ch))
                {
                    isLower = true;
                }
                else
                {
                    return "mixed";
                }
            }

            if (isUpper && isLower == false)

            {
                result = "upper";
            }
            else if (isLower && isUpper == false)
            {
                result = "lower";
            }

            return result;
        }
    }
}
