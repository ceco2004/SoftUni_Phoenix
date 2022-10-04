using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04._BasicOperationWitQueue
{
    class BasicOperationWitQueue
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int queueElements = input[0];
            int elementsToRemove = input[1];
            int searchedNumber = input[2];

            if(queueElements < elementsToRemove)
            {
                return;
            }

            else if(queueElements == elementsToRemove)
            {
                Console.WriteLine(0);
                return;
            }

            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(x => int.Parse(x)));

            for(int i = 0; i < elementsToRemove; i++)
            {
                numbers.Dequeue();
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
