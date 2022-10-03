using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrays = input.Split('|');
            List<string> result = new List<string>();

            for(int i = arrays.Length -1; i >= 0; i--)
            {
                string[] text = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                result.AddRange(text);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
