using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string text = File.ReadAllText($"{path}\\input.txt");

            string wordsPattern = @"[A-z]*[`|']?[A-z]+";

            string[] words = Regex.Matches(File.ReadAllText($"{path}\\words.txt"), wordsPattern)
                                .Select(m => m.Groups[0].Value).ToArray();
            string[] textWords = Regex.Matches(text, wordsPattern)
                                 .Select(m => m.Groups[0].Value).ToArray();

            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounter.ContainsKey(word.ToLower()) == false)
                {
                    wordCounter[word.ToLower()] = 0;
                }
            }

            foreach (string word in textWords)
            {
                if (wordCounter.ContainsKey(word.ToLower()))
                {
                    wordCounter[word.ToLower()]++;
                }
            }

            string[] linesToAppend = wordCounter.OrderByDescending(w => w.Value)
                                      .Select(w => $"{w.Key} - {w.Value}").ToArray();

            File.WriteAllLines($"{path}\\output.txt", linesToAppend);
        }
    }
}
