using System;
using System.Linq;

namespace Ex02._DiagonalsDiffrence
{
    class DiagonalsDiffrence
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            FillingTheMatrix(n, matrix);

            int[] d = CalculateDiagonals(matrix);

            int diff = Math.Abs(d[0] - d[1]);

            Console.WriteLine(diff);
        }


        private static int[] CalculateDiagonals(int[,] matrix)
        {
            int diagonal1 = 0;
            int diagonal2 = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonal1 += matrix[i, i];
                diagonal2 += matrix[i, matrix.GetLength(1) - i - 1];
            }

            return new int[] {diagonal1, diagonal2};
        }

        private static void FillingTheMatrix(int n, int[,] matrix)
        {
            for(int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();

                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
        }
    }
}
