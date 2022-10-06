using System;

namespace _04._SymbolInMatrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char searchedChar = char.Parse(Console.ReadLine());

                bool isFind = false;

            for(int i  = 0; i < matrix.GetLength(0); i++)
            {
                if (isFind)
                {
                    break;
                }

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == searchedChar)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFind = true;
                        break;
                    }
                }

                if(i == matrix.GetLength(0) - 1 && isFind == false)
                {
                    Console.WriteLine($"{searchedChar} is not occur in the matrix");
                }
            }
        }
    }
}
