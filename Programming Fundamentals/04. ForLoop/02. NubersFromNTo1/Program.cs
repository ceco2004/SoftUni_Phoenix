using System;

namespace _02._NubersFromNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            for(int i = startNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
