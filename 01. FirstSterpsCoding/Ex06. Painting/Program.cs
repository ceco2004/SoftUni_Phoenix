using System;

namespace Ex06._Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonPrice = 1.5;
            double paintPrice = 14.5;
            double ambPrice = 5;

            double bagsMoreMoney = 0.4;
            int extraPainPercentage = 10;
            int extraMoreNylon = 2;


            Console.Write("Enter needed square meter nylon: ");
            int nylon = int.Parse(Console.ReadLine());

            Console.Write("Enter needed paint in liters: ");
            int paint = int.Parse(Console.ReadLine());

            Console.Write("Enter needed AMB in liters: ");
            int amb = int.Parse(Console.ReadLine());

            Console.Write("Enter needed time for work i hours: ");
            int time = int.Parse(Console.ReadLine());

            double materialsPrice = (nylon + extraMoreNylon) * nylonPrice
                                    + (paint + paint * extraPainPercentage / 100) * paintPrice
                                    + amb * ambPrice
                                    + bagsMoreMoney;

            double workerMoney = time * (materialsPrice * 30 / 100);

            double allMoney = materialsPrice + workerMoney;

            Console.WriteLine($"For materials and workers You need: {allMoney} Money");

        }
    }
}
