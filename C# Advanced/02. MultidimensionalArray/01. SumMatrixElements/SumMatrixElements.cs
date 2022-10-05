using System;
using System.Linq;

namespace _01._SumMatrixElements
{
    class SumMatrixElements
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
                                   .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => int.Parse(x))
                                   .ToArray();
                for (int j = 0; j < Math.Min(c, elements.Length); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            int sum = 0;
            foreach (var el in matrix)
            {
                sum += el;
            }

            Console.WriteLine(sum);
        }
    }
}
