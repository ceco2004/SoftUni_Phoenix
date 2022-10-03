using System;
using System.Linq;

namespace Ex08._MostFrequentedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int mostFrequentedNumber = 0;
            int mostFrequentedCount = -1;

            int currentNumber = 0;
            int currentCount = 1;
            bool isRestarted = true;

            for(int i  = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        if (isRestarted)
                        {
                            isRestarted = false;
                            currentNumber = arr[i];
                        }

                        currentCount++;

                        if(j == arr.Length - 1)
                        {
                            isRestarted = true;

                            if (currentCount > mostFrequentedCount)
                            {
                                mostFrequentedCount = currentCount;
                                mostFrequentedNumber = currentNumber;
                            }
                        }
                    }
                   
                }
            }

            Console.WriteLine(mostFrequentedNumber);
        }
    }
}
