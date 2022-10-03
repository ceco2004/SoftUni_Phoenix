using System;

namespace Ex05._GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double dresPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 10 / 100;
            

            if(statist > 150)
            {
                dresPrice = dresPrice - dresPrice * 10 / 100; ;
            }

            double totalPrice = decorPrice + statist * dresPrice;

            double absMoney = budget - totalPrice;

            if(absMoney >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {absMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(absMoney):f2} leva more.");
            }
        }
    }
}
