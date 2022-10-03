using System;

namespace Ex03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());

            int less_200 = 0;
            int b200_399 = 0;
            int b400_599 = 0;
            int b600_799 = 0;
            int bigger_800 = 0;

            for(int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200) less_200++;
                else if (num <= 399) b200_399++;
                else if (num <= 599) b400_599++;
                else if (num <= 799) b600_799++;
                else bigger_800++;
            }
            string result = $"{less_200 / count * 100:f2}%";
            result += $"\n{b200_399 / count * 100:f2}%";
            result += $"\n{b400_599 / count * 100:f2}%";
            result += $"\n{b600_799 / count * 100:f2}%";
            result += $"\n{bigger_800 / count * 100:f2}%";

            Console.WriteLine(result);
        }
    }
}
