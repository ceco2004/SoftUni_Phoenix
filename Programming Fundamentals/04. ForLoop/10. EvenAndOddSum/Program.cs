using System;

namespace _10._EvenAndOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for(int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            string msg = string.Empty;

            if(evenSum == oddSum)
            {
                msg = "Yes";
                msg += $"\nSum = {evenSum}";
            }
            else
            {
                msg = "No";
                msg += $"\nDiff = {Math.Abs(evenSum - oddSum)}";
            }

            Console.WriteLine(msg);
        }
    }
}
