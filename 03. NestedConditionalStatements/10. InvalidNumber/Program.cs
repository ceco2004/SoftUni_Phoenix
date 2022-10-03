using System;

namespace _10._InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string report = string.Empty;

            if((num >= 100 && num <= 200) || num == 0)
            {
                report = "valid";
            }
            else
            {
                report = "invalid";
            }

            Console.WriteLine(report);
        }
    }
}
