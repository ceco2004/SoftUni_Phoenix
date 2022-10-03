using System;

namespace _12._Traders
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());

            double commission = -1;

            if(money >=0 && money <= 500)
            {
                if(town == "Sofia")
                {
                    commission = 5;
                } 
                else if(town == "Varna")
                {
                    commission = 4.5;
                }
                else if (town == "Plovdiv")
                {
                    commission = 5.5;
                }
            }
            else if(money > 500 && money <= 100)
            {
                if (town == "Sofia")
                {
                    commission = 7;
                }
                else if (town == "Varna")
                {
                    commission = 7.5;
                }
                else if (town == "Plovdiv")
                {
                    commission = 8;
                }
            }
            else if(money > 1000 && money <= 10000)
            {
                if (town == "Sofia")
                {
                    commission = 8;
                }
                else if (town == "Varna")
                {
                    commission =10 ;
                }
                else if (town == "Plovdiv")
                {
                    commission =12 ;
                }
            }
            else if (money > 10000)
            {
                if (town == "Sofia")
                {
                    commission = 12;
                }
                else if (town == "Varna")
                {
                    commission = 13;
                }
                else if (town == "Plovdiv")
                {
                    commission = 14.5;
                }
            }

            if(commission == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                
                Console.WriteLine($"{money*commission/100:f2}");
            }
        }
    }
}
