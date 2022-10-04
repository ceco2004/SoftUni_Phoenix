using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03._MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>(operations);

            for(int i = 0; i < operations; i++)
            {
                int[] data = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                switch (data[0])
                {
                    case 1:
                        numbers.Push(data[1]);
                        break;
                    case 2:
                        if(numbers.Count > 0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        Console.WriteLine(numbers.Max());
                        break;
                }
            }
        }
    }
}
