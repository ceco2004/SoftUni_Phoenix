using System;
using System.Linq;

namespace _06._ReverceStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            ReverceStringArray(words);
            Console.WriteLine(string.Join(" ", words));
        }

        static void ReverceStringArray(string[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
    }
}
