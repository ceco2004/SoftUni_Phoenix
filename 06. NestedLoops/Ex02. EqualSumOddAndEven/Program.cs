using System;

namespace Ex02._EqualSumOddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for(int i = firstNum; i <= secondNum; i++)
            {
                if (CheckDigit(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool CheckDigit (int num)
        {
            int sumOdd = 0;
            int sumEven = 0;
            string numAsString = num.ToString();
            for(int i = 0; i < numAsString.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sumEven += int.Parse(numAsString[i] + "");
                }
                else
                {
                    sumOdd += int.Parse(numAsString[i] + "");
                }
            }

            return sumEven == sumOdd;
        }
    }
}
