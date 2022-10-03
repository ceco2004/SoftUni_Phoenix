using System;

namespace _09._LeftAnRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for(int i = 0; i < 2*n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(i < n)
                {
                    firstSum += num;
                }
                else
                {
                    secondSum += num;
                }
            }
            string msg = string.Empty;
            if(firstSum == secondSum)
            {
                msg = $"Yes, sum = {firstSum}";
            }
            else
            {
                msg = $"No, diff = {Math.Abs(firstSum - secondSum)}";
            }
            Console.WriteLine(msg);
        }
    }
}
