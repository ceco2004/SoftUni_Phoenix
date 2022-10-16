using System;
using System.Linq;

namespace _03._CountUppercaseWord
{
    class CountUppercaseWord
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                            .Split(", .!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            string[] upperCaseWords = words
                                      .Where(w => char.IsUpper(w[0]))
                                      .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, upperCaseWords));
        }
    }
}
