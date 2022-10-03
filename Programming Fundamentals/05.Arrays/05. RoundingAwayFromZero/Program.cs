using System;
using System.Linq;

namespace _05._RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

            foreach(double num in numbers)
            {
                // Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");

               int awayFromZeroNum =  ConvertTheNumberAwayFromZero(num);
                Console.WriteLine($"{num} => {awayFromZeroNum}");
            }
        }

        static int ConvertTheNumberAwayFromZero(double num)
        {
            int beforeTheDot = (int)num;
            double part = Math.Abs(num) - Math.Abs(beforeTheDot);
            if (part >= 0.5)
            {
                if(beforeTheDot > 0)
                {
                    beforeTheDot++;
                }
                else
                {
                    beforeTheDot--;
                }

            }
            return beforeTheDot;

        }
    }
}
