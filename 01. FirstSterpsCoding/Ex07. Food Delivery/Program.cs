using System;

namespace Ex07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chikenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double veganMenuPrice = 8.15;

            double deliveryFee = 2.5;

            Console.Write("How many chiken menu You are want: ");
            int chikenMenus = int.Parse(Console.ReadLine());

            Console.Write("How many fish menu You are want: ");
            int fishMenus = int.Parse(Console.ReadLine());

            Console.Write("How many vegan menu You are want: ");
            int veganMenus = int.Parse(Console.ReadLine());

            double mealPrice = chikenMenus * chikenMenuPrice
                               + fishMenus * fishMenuPrice
                               + veganMenus * veganMenuPrice;

            double desertPrice = mealPrice * 20 / 100;

            Console.WriteLine($"For Your order You must pay {(mealPrice + desertPrice + deliveryFee):f2} Money");


        }
    }
}
