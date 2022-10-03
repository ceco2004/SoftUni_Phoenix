using System;

namespace _07._WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string status = string.Empty;

            if(hour >= 10 && hour < 18)
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        status = "open";
                        break;
                    case "Sunday":
                        status = "closed";
                        break;
                }
            }
            else
            {
                status = "closed";
            }
            Console.WriteLine(status);
        }
    }
}
