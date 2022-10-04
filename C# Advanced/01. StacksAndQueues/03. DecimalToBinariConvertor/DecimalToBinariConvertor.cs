using System;
using System.Collections.Generic;

namespace _03._DecimalToBinariConvertor
{
    class DecimalToBinariConvertor
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Stack<int> binary = new Stack<int>();

            while(input > 0)
            {
                binary.Push(input % 2);
                input /= 2;
            }

            while(binary.Count > 0)
            {
                Console.Write(binary.Pop());
            }

            Console.WriteLine();
        }
    }
}
