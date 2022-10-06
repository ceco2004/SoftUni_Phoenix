using System;
using System.Linq;

namespace _06._JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            FillMatrix(matrix);

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while(command[0] != "END")
            {

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int num = int.Parse(command[3]);

                if (row < 0 || col < 0 || row > matrix.Length - 1 || col > matrix[row].Length -1)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command.Contains("Add"))
                    {
                        Add(row, col, num, matrix);
                    }
                    else if (command.Contains("Subtract"))
                    {
                        Subtract(row, col, num, matrix);
                    } 
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach(int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void Add(int row, int col, int num, int[][] matrix)
        {
            matrix[row][col] += num;
        }

        private static void Subtract(int row, int col, int num, int[][] matrix)
        {
            matrix[row][col] -= num;
        }

        private static void FillMatrix(int[][] matrix)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                int[] col = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();

                matrix[i] = col;
            }
        }
    }
}
