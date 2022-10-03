using System;

namespace Ex03._Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double availabeMoney = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int daysSpend = 0;

            while (daysSpend < 5 && tripPrice > availabeMoney)
            {
                string act = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCounter++;

                if(act == "spend")
                {
                    availabeMoney = SpendMoney(availabeMoney, money);
                    daysSpend++;
                }
                else
                {
                    availabeMoney = SaveMoney(availabeMoney, money);
                    daysSpend = 0;
                }

            }

            string mesage = string.Empty;

            if(daysSpend == 5)
            {
                mesage = "You can't save the money.";
                mesage += $"\n{dayCounter}";
            }
            else
            {
                mesage = $"You saved the money for {dayCounter} days.";
            }

            Console.WriteLine(mesage);
        }

        private static double SaveMoney(double availableMoney, double money)
        {
            return availableMoney + money;
        } 
        private static double SpendMoney(double availabeMoney, double money)
        {
            if(availabeMoney <= money)
            {
                return 0;
            }
            else
            {
                return availabeMoney - money;
            }
        }
    }
}
