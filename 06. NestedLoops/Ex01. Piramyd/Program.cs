using System;

namespace Ex01._Piramyd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int col = 1; col <= n; col++)
            {
                bool breaked = false;
                for(int row = 1; row <= col; row++)
                {
                    Console.Write($"{++count} ");
                    if(count == n)
                    {
                        breaked = true;
                        break;
                    }
                }
                if (breaked)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
