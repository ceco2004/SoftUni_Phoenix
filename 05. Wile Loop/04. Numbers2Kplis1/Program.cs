using System;

namespace _04._Numbers2Kplis1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            int prevNum = 0;

            while(prevNum < max)
            {
                prevNum = 2 * prevNum + 1;
                Console.WriteLine(prevNum);
            }
        }
    }
}
