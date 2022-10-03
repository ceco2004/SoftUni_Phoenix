using System;
using System.Linq;

namespace Ex05._CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(s => s[0]).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(s => s[0]).ToArray();

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length) - 1; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    PrintSmalestArayFirst(arr1, arr2);
                    break;
                }
                else if (arr1[i] > arr2[i])
                {
                    PrintSmalestArayFirst(arr2, arr1);
                    break;
                }

                if (i == Math.Min(arr1.Length, arr2.Length) - 2)
                {
                    if (arr1.Length < arr2.Length)
                    {
                        PrintSmalestArayFirst(arr1, arr2);
                    }
                    else
                    {
                        PrintSmalestArayFirst(arr2, arr1);

                    }
                }
            }

            static void PrintSmalestArayFirst(char[] smalestArr, char[] biggestArr)
            {
                Console.WriteLine(string.Join("", smalestArr));
                Console.WriteLine(string.Join("", biggestArr));
            }

        }
    }
}
