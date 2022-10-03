using System;

namespace _04._EvenPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPower = int.Parse(Console.ReadLine());

            for(int i = 0; i <= endPower; i += 2)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
