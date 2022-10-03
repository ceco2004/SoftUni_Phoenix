using System;

namespace _05._Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = string.Empty;
            string input = Console.ReadLine();

            while(input != "End")
            {
               destination = input;
               int neededMoney = int.Parse(Console.ReadLine());
               int money = 0;

                while(neededMoney > money)
                {
                    money += int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");

                input = Console.ReadLine();
            }
        }
    }
}
