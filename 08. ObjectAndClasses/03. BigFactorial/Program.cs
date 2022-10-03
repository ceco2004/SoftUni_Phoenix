using System;
using System.Numerics;

namespace _03._BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = int.Parse(Console.ReadLine());
            BigInteger num = new BigInteger(1);

            for(int i = 1; i <= value; i++)
            {
                num *= i;
              
            }

            Console.WriteLine(num);
        }
    }
}
