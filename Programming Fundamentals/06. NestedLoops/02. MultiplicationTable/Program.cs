using System;

namespace _02._MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('=', 3) + $"  {i}  " + new string('=', 7));

                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine($"{j:d2} x {i:d2} = {j*i:d2}"); 
                }

            }
        }
    }
}
