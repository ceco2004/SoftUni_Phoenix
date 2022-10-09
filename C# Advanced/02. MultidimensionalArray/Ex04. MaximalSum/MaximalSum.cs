using System;
using System.Linq;
using System.Text;

namespace Ex04._MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(x => int.Parse(x))
                         .ToArray();

            int row = data[0];
            int col = data[1];

            int[,] matrix = new int[row, col];

            FilltTheMatrix(matrix);

            int[] rowCol = FindMaxSumSubMatrix(matrix);

            PrintSubMatrix(rowCol, matrix);
        }

        private static void PrintSubMatrix(int[] rowCol, int[,] matrix)
        {
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            for(int i = rowCol[0]; i < rowCol[0] + 3; i++)
            {
                for(int j = rowCol[1]; j < rowCol[1] + 3; j++)
                {
                    int element = matrix[i, j];
                    sum += element;
                    sb.Append(element + " ");
                }

                sb.AppendLine();
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine(sb.ToString());
        }

        private static int[] FindMaxSumSubMatrix(int[,] matrix)
        {
            // find submatrix with max sum with 3 X 3 dimestion

            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;

            for(int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                int sum = 0;
                
                for(int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = CalculateSubMatrixSum(i, j, matrix);

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;
                    }
                }
            }

            return new int[] { row, col };
        }

        private static int CalculateSubMatrixSum(int row, int col, int[,] matrix)
        {
            int sum = 0;
            for(int i = row; i < row + 3; i++)
            {
                for(int j = col; j < col + 3; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static void FilltTheMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
    }
}
