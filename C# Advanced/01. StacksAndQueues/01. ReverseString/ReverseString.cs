using System;
using System.Collections.Generic;

namespace _01._ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
           
            Stack<char> ch = new Stack<char>(Console.ReadLine().ToCharArray());

            while(ch.Count > 0)
            {
                Console.Write(ch.Pop());
            }
        }
    }
}
