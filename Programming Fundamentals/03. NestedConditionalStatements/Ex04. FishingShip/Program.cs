using System;

namespace Ex04._FishingShip
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishingMen = int.Parse(Console.ReadLine());

            int shipRent = 0;
            switch (season)
            {
                case "Spring": shipRent = 3000; break;
                case "Summer":
                case "Autumn": shipRent = 4200; break;
                case "Winter": shipRent = 2600; break;
            }

            int discount = 0;

            if(fishingMen <= 6)
            {
                discount = 10;
            }
            else if(fishingMen <= 11)
            {
                discount = 15;
            }
            else if(fishingMen >= 12)
            {
                discount = 25;
            }

            int aditionalDiscount = 0;
            if(fishingMen % 2 == 0 && season != "Autumn")
            {
                aditionalDiscount = 5;
            }

            double shipRentDiscounted = shipRent - shipRent * discount / 100;
            double finalRentPrice = shipRentDiscounted - shipRentDiscounted * aditionalDiscount / 100;

            string msg = string.Empty;
            double moreMoney = budget - finalRentPrice;

            if(moreMoney >= 0)
            {
                msg = $"Yes! You have {moreMoney:f2} leva left.";
            }
            else
            {
                msg = $"Not enough money! You need {Math.Abs(moreMoney):f2} leva.";
            }

            Console.WriteLine(msg);

        }
    }
}
