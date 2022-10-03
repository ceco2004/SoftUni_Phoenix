using System;

namespace _05._StreamOfSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = Console.ReadLine();
            for(int i = 0; i < source.Length; i++)
            {
                Console.WriteLine(source[i]);
            }

            //foreach(char a in source)
            //{
            //    Console.WriteLine(a);
            //}
        }
    }
}
