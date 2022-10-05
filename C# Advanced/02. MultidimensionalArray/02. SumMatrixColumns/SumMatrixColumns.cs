using System;
using System.Linq;

namespace _02._SumMatrixColumns
{
    class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                            .Split(",", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();
            int r = data[0];
            int c = data[1];

            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                int[] elements = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => int.Parse(x))
                                   .ToArray();
                for (int j = 0; j < Math.Min(c, elements.Length); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;

                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine($"The sum of elements ot col {i+1} is: {sum}");
            }
        }
    }
}
