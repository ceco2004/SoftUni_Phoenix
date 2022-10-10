using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04._EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(num) == false)
                {
                    dict[num] = 0;
                }

                dict[num]++;
            }

            Console.WriteLine(string.Join(" ", dict.Where(d => d.Value % 2 == 0).Select(x => x.Key)));

        }
    }
}
