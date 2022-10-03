using System;
using System.Linq;

namespace _09._Extract1_2Or3Element
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().ToArray();
            string result = string.Empty;

            if (elements.Length == 1)
            {
                result = elements[0];
            }
            else if(elements.Length % 2 == 0)
            {
               result = ExtractIfHaveEvenElements(elements);

            }
            else
            {
                result = ExtractIfOddElements(elements);
            }

            Console.WriteLine($"{{{result}}}");

        }

        static string ExtractIfHaveEvenElements (string [] elements)
        {
            int firstIndex = elements.Length / 2 - 1;
            return $"{elements[firstIndex]}, {elements[firstIndex + 1]}";
        }

        static string ExtractIfOddElements(string[] elements)
        {
            int firstIndex = elements.Length / 2 - 1;
            return $"{elements[firstIndex]}, {elements[firstIndex + 1]}, {elements[firstIndex + 2]}";
        }
    }
}
