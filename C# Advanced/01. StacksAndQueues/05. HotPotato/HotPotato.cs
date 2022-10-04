using System;
using System.Collections.Generic;

namespace _05._HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> qKids = new Queue<string>(kids);

            while(qKids.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    qKids.Enqueue(qKids.Dequeue());
                }

                Console.WriteLine($"Removed {qKids.Dequeue()}");
            }
            Console.WriteLine($"Last is {qKids.Dequeue()}");
        }
    }
}
