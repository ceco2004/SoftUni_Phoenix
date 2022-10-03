using System;

namespace _08._Yards_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many meters is your yard: ");
            int yard = int.Parse(Console.ReadLine());
            int disscount = 0;
            double pricePerMeter = 7.61;
            double price = pricePerMeter * yard;
            string specialPrice = "";

            if (yard >= 10)
            {
                disscount = 18;
                Console.WriteLine($"You have {disscount}% discount.");
                double lowerPrice = price - price * disscount / 100;
                specialPrice = $"Your price is {lowerPrice:F2}$";
            }

            Console.WriteLine($"The regular price is {price:F2}$");
            Console.WriteLine(specialPrice);
            

        }
    }
}
