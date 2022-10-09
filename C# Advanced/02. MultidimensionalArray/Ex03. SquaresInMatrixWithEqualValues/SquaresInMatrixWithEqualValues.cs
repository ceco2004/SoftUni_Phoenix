using System;
using System.Linq;

namespace Ex03._SquaresInMatrixWithEqualValues
{
    class SquaresInMatrixWithEqualValues
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();
            int row = rowCol[0];
            int col = rowCol[1];

            int subMatrix = 0;
            
            if(row >= 2 && col >= 2)
            {
                char[,] matrix = new char[row, col];

                FilltTheMatrix(matrix);

                subMatrix = SearchEqualSubmatrix(matrix);
            }

            Console.WriteLine(subMatrix);
        }


        private static int SearchEqualSubmatrix(char[,] matrix)
        {
            int subMatrix = 0;

            for(int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for(int j = 0; j < matrix.GetLength(1) -1; j++)
                {
                    if(matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j + 1]
                        && matrix[i, j] == matrix[i + 1, j])
                    {
                        subMatrix++;
                    }
                }
            }


            return subMatrix;
        }
        private static void FilltTheMatrix(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] chars =  Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(c => char.Parse(c))
                                .ToArray();

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = chars[j];
                }
            }
        }
    }
}
