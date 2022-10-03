using System;

namespace _03._LasKElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            numbers[0] = 1;

            for(int i = 1; i < n; i++)
            {
                int sum = 0;

                for(int j = i; j >= i - k; j--)
                {
                    if(j < 0)
                    {
                        break;
                    }
                    sum += numbers[j];
                }
                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
