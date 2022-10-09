using System;
using System.Linq;

namespace Ex01._MatrixOfPalindroms
{
    class MatrixOfPalindroms
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

            char[] alfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            int row = rowCol[0];
            int col = rowCol[1];

            string[,] matrix = new string[row, col];

            for(int i = 0; i < row; i++)
            {
                int r = i % alfabet.Length;

                for(int j = 0; j < col; j++)
                {
                    string data = string.Empty;

                    if(j == 0)
                    {
                        data = new string(alfabet[r], 3);
                    }
                    else
                    {
                        data = $"{alfabet[r]}{alfabet[(r+j) % alfabet.Length]}{alfabet[r]}";
                    }

                    matrix[i, j] = data;
                }
            }

            PrintMatrix(matrix);

        }

        public static void PrintMatrix(string[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if(j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
