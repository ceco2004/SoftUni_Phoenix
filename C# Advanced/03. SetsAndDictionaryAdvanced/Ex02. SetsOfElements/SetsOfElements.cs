using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02._SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] length = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(x => int.Parse(x))
                           .ToArray();

            HashSet<int> first = InputSet(length[0]);
            HashSet<int> second = InputSet(length[1]);

            foreach(int num in first)
            {
                if (second.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }

        private static HashSet<int> InputSet(int n)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set.Add(num);
            }
            return set;
        }
    }
}
