using System;

namespace _01._DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 7)
            {
                n = 0;
            }

            Console.WriteLine(dayOfWeek[n]);


        }
    }
}
