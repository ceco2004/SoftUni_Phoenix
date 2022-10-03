using System;

namespace Ex02._BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;

            if(num <= 100)
            {
                bonus += 5;
            }
            else if(num > 1000)
            {
                bonus += num * 10 / 100.0;
            }
            else if (num > 100)
            {
                bonus += num * 20 / 100.0;
            }

            if(num % 2 == 0)
            {
                bonus += 1;
            }
            else if(num % 5 == 0)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);
        }
    }
}
