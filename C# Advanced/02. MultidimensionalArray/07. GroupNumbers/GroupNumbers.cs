using System;
using System.Linq;

namespace _07._GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();

            int[][] groupMatrix = new int[3][];

            for(int i = 0; i <= 2; i++)
            {
                groupMatrix[i] = numbers.Where(x => Math.Abs(x % 3) == i).ToArray();
            }

            foreach(int[] row in groupMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
