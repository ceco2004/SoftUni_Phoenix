using System;

namespace Ex03._ConvertToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                Console.Write($"\\u{((int)ch).ToString("X").PadLeft(4, '0')}");
            }
            Console.WriteLine();
        }
    }
}
