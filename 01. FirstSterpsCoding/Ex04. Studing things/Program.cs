using System;

namespace Ex04._Studing_things
{
    class Program
    {
        static void Main(string[] args)
        {
            double pensPrice = 5.8;
            double markersPrice = 7.2;
            double biocidePrice = 1.2;

            Console.Write("Please enter how many pens You need: ");
            int pens = int.Parse(Console.ReadLine());

            Console.Write("Please enter how many markers You need: ");
            int markers = int.Parse(Console.ReadLine());

            Console.Write("Please enter how many liters biocide You need: ");
            int biocide = int.Parse(Console.ReadLine());

            Console.Write("Please enter how many percent discount you have: ");
            int discount = int.Parse(Console.ReadLine());

            double totalPrice = (pens * pensPrice + markers * markersPrice + biocide * biocidePrice);
            double discountedPrice = totalPrice - totalPrice * discount / 100;

            Console.WriteLine($"For all of things You need: {discountedPrice:f2} Money");
        }
    }
}
