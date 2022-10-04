using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> calcStack = new Stack<string>(input.Reverse());

            while(calcStack.Count > 1)
            {
                int firstNum = int.Parse(calcStack.Pop());
                string operand = calcStack.Pop();
                int secondNum = int.Parse(calcStack.Pop());

                switch (operand)
                {
                    case "+": calcStack.Push((firstNum + secondNum).ToString());
                        break;
                    case "-": calcStack.Push((firstNum - secondNum).ToString());
                        break;
                }
            }

            Console.WriteLine(calcStack.Pop());
        }
    }
}
