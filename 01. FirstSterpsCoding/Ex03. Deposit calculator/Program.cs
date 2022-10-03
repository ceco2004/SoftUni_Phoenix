using System;

namespace Ex03._Deposit_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Please enter term in monts: ");
            int monts = int.Parse(Console.ReadLine());

            Console.Write("Please enter the annual: ");
            double annual = double.Parse(Console.ReadLine());

            double sum = amount + monts*((amount/100 * annual) / 12);

            Console.WriteLine($"From yours amount {amount} after {monts} monats you shoud have {sum:F2}");
        }
    }
}
