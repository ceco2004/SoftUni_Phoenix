using System;

namespace Ex05._Traveler
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            int percentsSpendedBudget = 0;
            string place = string.Empty;
            string destination = string.Empty;

            switch (season)
            {
                case "summer": place = "Camp"; break;
                case "winter": place = "Hotel"; break;
            }

            if(budget <= 100)
            {
                switch (season)
                {
                    case "summer": percentsSpendedBudget = 30; break;
                    case "winter": percentsSpendedBudget = 70; break;
                }
                destination = "Bulgaria";
            }
            else if(budget <= 1000)
            {
                switch (season)
                {
                    case "summer": percentsSpendedBudget = 40; break;
                    case "winter": percentsSpendedBudget = 80; break;
                }
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                percentsSpendedBudget = 90;
                destination = "Europe";
                place = "Hotel";
            }

            double spendMoney = budget * percentsSpendedBudget / 100;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} – {spendMoney:f2}");
        }
    }
}
