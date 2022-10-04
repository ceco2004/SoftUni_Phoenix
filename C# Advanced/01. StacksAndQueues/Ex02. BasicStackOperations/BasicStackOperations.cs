using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02._BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int elemetnsToPush = data[0];
            int elementsToPop = data[1];
            int searchedNumber = data[2];

            if(elemetnsToPush < elementsToPop)
            {
                return;
            }

            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)));

            for(int i = 0; i < elementsToPop; i++)
            {
                numbers.Pop();
            }

            bool isAvailable = numbers.Contains(searchedNumber);

            if (isAvailable)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
