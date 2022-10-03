using System;

namespace _02._WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            string typeOfDay = string.Empty;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    typeOfDay = "Working day";
                    break;
                case "Saturday":
                case "Sunday":
                    typeOfDay = "Holiday";
                    break;
                default:
                    typeOfDay = "ERROR";
                    break;
            }
            Console.WriteLine(typeOfDay);
    }
    }
}
