using System;
using System.Linq;

namespace _05._SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                            .Split(",", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();

            int[,] matrix = new int[data[0], data[1]];

            FillingMatrix(matrix);
            int[] startIndex = FindSubMatrixWithMaximumSum(matrix);
            PrintSubMatrixAndSum(startIndex, matrix);
        }

        private static void PrintSubMatrixAndSum(int[] startIndex, int[,] matrix)
        {
            int sum = 0;
            for(int i = startIndex[0]; i < startIndex[0] + 2; i++)
            {
                for(int j = startIndex[1]; j < startIndex[1] + 2; j++)
                {
                    int a = matrix[i, j];
                    sum += a;

                    Console.Write($"{a} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(sum);
        }

        private static int[] FindSubMatrixWithMaximumSum(int[,] matrix)
        {
            int indexI = 0;
            int indexJ = 0;
            int maximumSum = int.MinValue;

            for(int i  = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for(int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if(sum > maximumSum)
                    {
                        maximumSum = sum;
                        indexI = i;
                        indexJ = j;
                    }
                }
            }



            return new int[] {indexI, indexJ};
        }

        private static void FillingMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] values = Console.ReadLine()
                                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }
        }
    }
}
