using System;

namespace Ex05._SpecialNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 1111; i <= 9999; i++)
            {
                if(IsSpecial(i, num))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool IsSpecial(int a, int num)
        {
            string nuberAsString = a.ToString();
            for(int i = 0; i < nuberAsString.Length; i++)
            {
                int digit = int.Parse(nuberAsString[i] + "");
                if(digit == 0)
                {
                    continue;
                }

                if(num % digit != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
