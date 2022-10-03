using System;
using System.Linq;

namespace Ex11._EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            bool haveEqual = false;
            for(int i = 0; i < arr.Length; i++)
            {
                int leftSum = CalculateLeftSum(i, arr);
                int rightSum = CalculateRightSum(i, arr);

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    haveEqual = true;
                }
            }
             if(haveEqual == false)
            {
                Console.WriteLine("no");
            }
            
        }
        static int CalculateRightSum(int index, int[] arr)
        {
            if(index == arr.Length - 1)
            {
                return 0;
            }

            int sum = 0;
            
            for(int i = arr.Length -1; i > index; i--)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int CalculateLeftSum(int index, int[] arr)
        {
            if(index == 0)
            {
                return 0;
            }
            int sum = 0;

            for(int i = 0; i < index; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
