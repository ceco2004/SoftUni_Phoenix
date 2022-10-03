using System;

namespace Ex03._NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flowers)
            {
                case "Roses":
                    price = 5; break;
                case "Dahlias":
                    price = 3.8; break;
                case "Tulips":
                        price = 2.8; break;
                case "Narcissus":
                    price = 3; break;
                case "Gladiolus":
                    price = 2.5; break;
            }

            int discount = 0;

            if(flowers == "Roses" && quantity > 80)
            {
                discount = 10;
            } 
            else if((flowers == "Dahlias" && quantity > 90)
                || (flowers == "Tulips" && quantity > 80))
            {
                discount = 15;
            }
            else if(flowers == "Narcissus" && quantity < 120)
            {
                discount = -15;
            }
            else if(flowers == "Gladiolus" && quantity < 80)
            {
                discount = -20;
            }

            double flowersPrice = price * quantity;
            double neededMoney = flowersPrice - flowersPrice * discount / 100;

            string message = string.Empty;
            double diffrenceMoney = budget - neededMoney;

            if(budget >= neededMoney)
            {
                message = $"Hey, you have a great garden with {quantity} {flowers} and {diffrenceMoney:F2} leva left.";
            }
            else
            {
                message = $"Not enough money, you need {Math.Abs(diffrenceMoney):F2} leva more.";
            }
            Console.WriteLine(message);
        }
    }
}
