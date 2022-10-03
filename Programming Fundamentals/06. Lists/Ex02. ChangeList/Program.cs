using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02._ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            bool endProgramm = false;
            while (endProgramm == false)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Delete": 
                        while(numbers.Remove(int.Parse(command[1]))); break;
                    case "Insert": numbers.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
                    case "Odd":
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 != 0)));
                        endProgramm = true; break;
                    case "Even":
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 == 0)));
                        endProgramm = true; break;
                }
            }

        }
    }
}
