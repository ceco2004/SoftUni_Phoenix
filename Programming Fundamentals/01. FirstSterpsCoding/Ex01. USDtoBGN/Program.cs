using System;

namespace Ex01._USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double exchangeRate = 1.79549;

            Console.Write("Please input how many Dollars You want to exchange: ");
            double dollars = double.Parse(Console.ReadLine());

            Console.WriteLine($"{dollars} dollars are {dollars * exchangeRate:F2} bulgarian leva");
        }
    }
}
