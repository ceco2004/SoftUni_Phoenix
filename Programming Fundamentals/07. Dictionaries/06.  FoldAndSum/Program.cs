using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.__FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int k = numbers.Length / 4;
            List<int> firstRow = numbers.Take(k).Reverse().ToList();
            firstRow.AddRange((numbers.TakeLast(k)).Reverse().ToList());
            List<int> secondRow = numbers.Skip(k).Take(2 * k).ToList();

            //List<int> result = new List<int>();
            //for(int i = 0; i < firstRow.Count; i++)
            //{
            //    result.Add(firstRow[i] + secondRow[i]);
            //}

            List<int> result = firstRow.Select((x, index) => x + secondRow[index]).ToList();

            Console.WriteLine(string.Join(' ', result)); ;
        }
    }
}
