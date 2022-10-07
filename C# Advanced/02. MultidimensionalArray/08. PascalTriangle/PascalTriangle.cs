using System;

namespace _08._PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rowCount][];
            matrix[0] = new int[] { 1 };

            for (int row = 1; row < rowCount; row++)
            {
                matrix[row] = new int[row + 1];

                for (int col = 0; col <= row; col++)
                {
                    if (col >= 1)
                    {
                        if (matrix[row - 1].Length - 1 >= col)
                        {
                            matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
                        }
                        else
                        {
                            matrix[row][col] = matrix[row - 1][col - 1];
                        }
                    }
                    else
                    {
                        matrix[row][col] = matrix[row - 1][col];
                    }
                }
            }

            foreach(int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
