using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int counter = 0;

            for(int a = 0; a <= num; a++)
            {
                for(int b = 0; b <= num; b++)
                {
                    for(int c = 0; c <= num; c++)
                    {
                        if(a + b + c == num)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
