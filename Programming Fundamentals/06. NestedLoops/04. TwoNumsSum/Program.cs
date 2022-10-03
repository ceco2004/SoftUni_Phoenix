using System;

namespace _04._TwoNumsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int magicNum = int.Parse(Console.ReadLine());
            int combinationCounter = 0;

            string msg = string.Empty;

            for(int i = num1; i <= num2; i++)
            {
                for(int j = num1; j <= num2; j++)
                {
                    combinationCounter++;
                    if(i + j == magicNum)
                    {
                        msg = $"Combination N:{combinationCounter} ({i} + {j} = {magicNum})";
                        break;
                    }
                    if(msg != string.Empty)
                    {
                        break;
                    }
                }
            }

            if(msg == string.Empty)
            {
                msg = $"{combinationCounter} combinations - neither equals {magicNum}";
            }

            Console.WriteLine(msg);

        }
    }
}
