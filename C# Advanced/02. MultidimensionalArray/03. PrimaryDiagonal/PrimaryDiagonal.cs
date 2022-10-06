using System;
using System.Linq;

namespace _03._PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for( int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] values = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine($"Primary diagonal sum is: {sum}");
        }
    }
}
