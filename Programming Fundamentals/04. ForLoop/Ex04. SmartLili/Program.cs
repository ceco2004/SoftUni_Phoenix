using System;

namespace Ex04._SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int saved = 0;
            int evenCounter = 1;
            for(int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    saved += 10 * evenCounter - 1;
                    evenCounter++;
                }
                else
                {
                    saved += toyPrice;
                }
            }

            string msg = string.Empty;
            double diff = saved - washingMashinePrice;
            if(diff >= 0)
            {
                msg = $"Yes! {diff:f2}";
            }
            else
            {
                msg = $"No! {Math.Abs(diff):f2}";
            }
            Console.WriteLine(msg);
        }
    }
}
