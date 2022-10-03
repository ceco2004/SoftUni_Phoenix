using System;

namespace Ex08._Basketball_equipoment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter yearly basketball fee: ");
            int basketFee = int.Parse(Console.ReadLine());

            double shoesPrice = basketFee - basketFee * 40 / 100;
            double tshirtPrice = shoesPrice - shoesPrice * 20 / 100;
            double ballPrice = tshirtPrice * 25 / 100;
            double accesoriesPrice = ballPrice * 20 / 100;

            double totalPrice = basketFee + shoesPrice + tshirtPrice + ballPrice + accesoriesPrice;

            Console.WriteLine($"All money You need : {totalPrice:f2}");
        }
    }
}
