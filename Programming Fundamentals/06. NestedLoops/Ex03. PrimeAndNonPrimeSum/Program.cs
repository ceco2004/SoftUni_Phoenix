using System;

namespace Ex03._PrimeAndNonPrimeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while(input != "stop")
            {
                int num = int.Parse(input);
                if(num < 0)
                {
                    Console.WriteLine("Number is negative.");
                } 
                else if(num == 1)
                {
                    primeSum += num;
                }
                else if (IsPrime(num))
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }

        static bool IsPrime(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
