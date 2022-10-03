using System;
using System.Linq;

namespace Ex04._CharMultiplyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().ToArray();

            string w1 = data[0];
            string w2 = data[1];

            double sum = CalculateSum(w1, w2);

            Console.WriteLine(sum);
        }

        private static double CalculateSum(string w1, string w2)
        {
            double result = 0;

            for(int i = 0; i < Math.Max(w1.Length, w2.Length); i++)
            {
                double first = 1;
                if(w1.Length > i)
                {
                    first = (double)w1[i];
                }


                double second = 1;
                if(w2.Length > i)
                {
                    second = (double)w2[i];
                }

                result += first * second;
            }

            return result;
        }
    }
}
