using System;

namespace Ex04._ToysShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double puzzlePrice = 2.6;
            double barbyPrice = 3;
            double bearPrice = 4.1;
            double minionPrice = 8.2;
            double truckPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int barbyes = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int discount = 0;

            int allToys = puzzels + barbyes + bears + minions + trucks;

            if(allToys >= 50)
            {
                discount = 25;
            }

            double sum = puzzels * puzzlePrice
                        + barbyes * barbyPrice
                        + bears * bearPrice
                        + minions * minionPrice
                        + trucks * truckPrice;

            double totalSum = sum - sum * discount / 100;
            double rent = totalSum * 10 / 100;
            double moreMoney = totalSum - tripPrice - rent;

            if(moreMoney >= tripPrice)
            {
                Console.WriteLine($"Yes! {moreMoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(moreMoney):f2} lv needed.");
            }
        }
    }
}
