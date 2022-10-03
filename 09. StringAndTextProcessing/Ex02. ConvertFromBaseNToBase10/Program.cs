using System;
using System.Linq;

namespace Ex02._ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            double baseN = double.Parse(data[0]);
            string numAsString = data[1];

            double result = 0;
            double pow = 0;

            for(int i = numAsString.Length - 1; i >= 0; i--)
            {
                result += int.Parse(numAsString[i].ToString()) * Math.Pow(baseN, pow);
                pow++;
            }

            Console.WriteLine(result);

        }
    }
}
