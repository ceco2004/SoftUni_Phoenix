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
            int row = rowCol[0];
            int col = rowCol[1];

            char[] alfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[,] matrix = new string[row, col];

            for(int i = 0; i < row; i++)
            {

                for(int j = 0; j < col; j++)
                {
                    string data = string.Empty;

                    if(j == 0)
                    {
                        data = new string(alfabet[i], 3);
                    }
                    else
                    {
                        data = $"{alfabet[i]}{alfabet[i+j]}{alfabet[i]}";
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
