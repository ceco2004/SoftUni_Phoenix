using System;

namespace Ex07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int vgaItems = int.Parse(Console.ReadLine());
            int cpuItems = int.Parse(Console.ReadLine());
            int ramItems = int.Parse(Console.ReadLine());

            double vgaPrice = 250;

            double vgaMoney = vgaItems * vgaPrice;
            double cpuPrice = vgaMoney * 35 / 100;
            double ramPrice = vgaMoney * 10 / 100;

            double cpuMoney = cpuItems * cpuPrice;
            double ramMoney = ramItems * ramPrice;

            int discount = 0;

            if(vgaItems > cpuItems)
            {
                discount = 15;
            }

            double totalMoney = vgaMoney + cpuMoney + ramMoney;
            double moneyWithDiscount = totalMoney - totalMoney * discount / 100;

            string msg = string.Empty;
            double moneyAbs = budget - moneyWithDiscount;

            if(moneyAbs >= 0)
            {
                msg = $"You have {moneyAbs:f2} leva left!";
            }
            else
            {
                msg = $"Not enough money! You need {Math.Abs(moneyAbs):f2} leva more!";
            }

            Console.WriteLine(msg);
        }
    }
}
