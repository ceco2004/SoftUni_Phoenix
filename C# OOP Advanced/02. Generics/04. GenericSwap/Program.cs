using System;

namespace _04._GenericSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] {"First","Second","Third"};
            int[] intArr = new int[]{ 1, 2, 3 };

            SwapElements.Swap(0, 2, strArr);
            SwapElements.Swap(1, 2, intArr);

            Console.WriteLine(string.Join(" ", strArr));
            Console.WriteLine(string.Join(" ", intArr));
        }
    }
}
