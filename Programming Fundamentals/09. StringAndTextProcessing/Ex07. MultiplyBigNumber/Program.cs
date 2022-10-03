using System;
using System.Linq;

namespace Ex07._MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            decimal num2 = decimal.Parse(Console.ReadLine());

            string result = string.Empty;

            int forMore = 0;
            for(int i = numAsString.Length-1; i >= 0; i--)
            {
                int currentNum = int.Parse(numAsString[i].ToString());
                decimal multipied = currentNum * num2 + forMore;

                result += multipied % 10;
                forMore = (int)multipied / 10;
            }

            if(forMore != 0)
            {
                result += forMore;
            }

            Console.WriteLine(new string(result.Reverse().ToArray()));
        }
    }
}
