using System;

namespace _11._FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            string typeOfDay = string.Empty;
            bool error = false;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    typeOfDay = "Working";
                    break;
                case "Saturday":
                case "Sunday":
                    typeOfDay = "Holiday";
                    break;
                default:
                    error = true;
                    break;
            }

            double price = 0;

            if(typeOfDay == "Working")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.5;
                        break;
                    case "apple":
                        price = 1.2;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.7;
                        break;
                    case "pineapple":
                        price = 5.5;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        error = true;
                        break;
                            
                }
            }
            else if (typeOfDay == "Holiday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.7;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.9;
                        break;
                    case "grapefruit":
                        price = 1.6;
                        break;
                    case "kiwi":
                        price = 3;
                        break;
                    case "pineapple":
                        price = 5.6;
                        break;
                    case "grapes":
                        price = 4.2;
                        break;
                    default:
                        error = true;
                        break;

                }
            }
            else
            {
                error = true;
            }

            if (error)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{price * quantity:f2}");
            }
        }
    }
}
