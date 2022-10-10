using System;
using System.Collections.Generic;

namespace Ex03._PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach(string element in data)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
