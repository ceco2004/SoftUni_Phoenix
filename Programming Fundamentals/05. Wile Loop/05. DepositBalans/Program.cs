using System;

namespace _05._DepositBalans
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            double deposit = 0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money >= 0)
                {
                    deposit += money;
                    Console.WriteLine("Increase: {0}", money);
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total {deposit}");


        }
    }
}
