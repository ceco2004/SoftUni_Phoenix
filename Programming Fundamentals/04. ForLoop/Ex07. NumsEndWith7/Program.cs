using System;

namespace Ex01._NumsEndWith7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)
            {
                if(i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
