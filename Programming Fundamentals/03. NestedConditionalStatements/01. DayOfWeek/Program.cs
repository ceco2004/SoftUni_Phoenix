using System;

namespace _01._DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string nameOfDay = string.Empty;
            switch (day)
            {
                case 1:
                    nameOfDay = "Monday";
                    break;
                case 2:
                    nameOfDay = "Tuesday";
                    break;
                case 4:
                    nameOfDay = "Thursday";
                    break;
                case 3:
                    nameOfDay = "Wednesday";
                    break;
                case 5:
                    nameOfDay = "Friday";
                    break;
                case 6:
                    nameOfDay = "Saturday";
                    break;
                default:
                    nameOfDay = "Error";
                    break;
            }
            Console.WriteLine(nameOfDay);

        }
    }
}
