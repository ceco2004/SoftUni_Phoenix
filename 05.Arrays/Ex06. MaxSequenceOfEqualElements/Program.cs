using System;
using System.Linq;

namespace Ex06._MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            int currentStartIndex = 0;
            int currentLength = 1;
            bool isRestartedIndex = true;

            int maxStartIndex = -1;
            int maxLength = -1;

           
            for(int i = 0; i <= arr.Length - 2; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    if (isRestartedIndex)
                    {
                        isRestartedIndex = false;
                        currentStartIndex = i;
                    }

                    currentLength++;

                    if(i == arr.Length - 2)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            maxStartIndex = currentStartIndex;
                        }
                    }
                }
                else
                {
                    if(currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }

                    isRestartedIndex = true;
                    currentLength = 1;
                }

            }

            for(int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
