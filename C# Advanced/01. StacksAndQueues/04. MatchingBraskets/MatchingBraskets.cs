using System;
using System.Collections.Generic;

namespace _04._MatchingBraskets
{
    class MatchingBraskets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> brasketIndex = new Stack<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    brasketIndex.Push(i);
                }
                else if(input[i] == ')')
                {
                    Console.WriteLine(input.Substring(brasketIndex.Peek(), i - brasketIndex.Pop()+ 1));
                }
            }
        }
    }
}
