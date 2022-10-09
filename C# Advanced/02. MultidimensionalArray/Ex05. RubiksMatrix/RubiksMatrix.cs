using System;
using System.Linq;

namespace Ex05._RubiksMatrix
{
    class RubiksMatrix
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

            int comandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < comandCount; i++)
            {
                string[] comand = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();
                int coordinates = int.Parse(comand[0]);
                string direction = comand[1];
                int moovingPlaces = int.Parse(comand[2]);

                SwapElements(direction, coordinates, moovingPlaces, matrix);
                PrintMatrix(matrix);
            }

            ResetTheMatrix(matrix);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[j, k] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ResetTheMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    int correctValue = i * matrix.GetLength(0) + j + 1;

                    if(matrix[i, j] != correctValue)
                    {
                        ExchangeValues(i, j, matrix);
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                }
            }
        }

        private static void ExchangeValues(int row, int col, int[,] matrix)
        {
            int valueOnWrongPlace = matrix[row, col];

            int targetRow = (valueOnWrongPlace - 1) / matrix.GetLength(0);
            int targetCol = valueOnWrongPlace - targetRow * matrix.GetLength(0) - 1;

            int targetValue = matrix[targetRow, targetCol];

            int correctValueOnTargetPlace = targetRow * matrix.GetLength(0) + targetCol + 1;

            if (valueOnWrongPlace != correctValueOnTargetPlace)
            {
                ExchangeValues(targetRow, targetCol, matrix);
            }
            else
            {
                matrix[row, col] = targetValue;
                matrix[targetRow, targetCol] = valueOnWrongPlace;

                Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
            }
        }

        private static void SwapElements(string direction, int coordinates, int moovingPlaces, int[,] matrix)
        {
            switch (direction)
            {
                case "up":
                    if(coordinates - moovingPlaces >= 0)
                    {
                        int target = matrix[coordinates - moovingPlaces, coordinates];
                        matrix[coordinates - moovingPlaces, coordinates] = matrix[coordinates, coordinates];
                        matrix[coordinates, coordinates] = target;
                    }
                    break;
                case "down":
                    if(coordinates + moovingPlaces < matrix.GetLength(1))
                    {
                        int target = matrix[coordinates + moovingPlaces, coordinates];
                        matrix[coordinates + moovingPlaces, coordinates] = matrix[coordinates, coordinates];
                        matrix[coordinates, coordinates] = target;
                    }
                    break;
                case "left":
                    if(coordinates - moovingPlaces >= 0)
                    {
                        int target = matrix[coordinates, coordinates - moovingPlaces];
                        matrix[coordinates, coordinates - moovingPlaces] = matrix[coordinates, coordinates];
                        matrix[coordinates, coordinates] = target;
                    }
                    break;
                case "right":
                    if (coordinates + moovingPlaces < matrix.GetLength(0))
                    {
                        int target = matrix[coordinates, coordinates + moovingPlaces];
                        matrix[coordinates, coordinates + moovingPlaces] = matrix[coordinates, coordinates];
                        matrix[coordinates, coordinates] = target;
                    }
                    break;
            }
        }

        private static void FilltTheMatrix(int[,] matrix)
        {
            int count = 1;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count++;
                }
            }
        }
    }
}
