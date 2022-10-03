using System;
using System.Linq;

namespace Ex01._ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int baseN = data[0];
            int number = data[1];

            string result = string.Empty;

            while(number != 0)
            {
                result += (number % baseN).ToString();
                number /= baseN;
            }

            Console.WriteLine(new string(result.Reverse().ToArray()));
        }
    }
}
