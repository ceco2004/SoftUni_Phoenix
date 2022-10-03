using System;

namespace Ex02._OneEqualToAllSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for(int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num > max)
                {
                    max = num;
                }

                sum += num;
            }
            sum -= max;
            int diff = Math.Abs(max - sum);
            string msg = string.Empty;
            if(diff == 0)
            {
                msg = "Yes";
                msg += $"\nSum = {sum}";
            }
            else
            {
                msg = "No";
                msg += $"\nDiff = {diff}";
            }
            Console.WriteLine(msg);
        }
    }
}
