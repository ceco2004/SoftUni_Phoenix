using System;

namespace Ex06._OperationsbetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();

            string result = string.Empty;
            string oddEven = string.Empty;


            switch (operand)
            {
                case "+":
                    if((n1 + n2) % 2 != 0)
                    {
                        oddEven = "odd";
                    }
                    else
                    {
                        oddEven = "even";
                    }
                    result = $"{n1} + {n2} = {n1 + n2} - {oddEven}";
                    break;

                case "-":
                    if ((n1 - n2) % 2 != 0)
                    {
                        oddEven = "odd";
                    }
                    else
                    {
                        oddEven = "even";
                    }
                    result = $"{n1} - {n2} = {n1 + n2} - {oddEven}";
                    break;

                case "*":
                    if ((n1 * n2) % 2 != 0)
                    {
                        oddEven = "odd";
                    }
                    else
                    {
                        oddEven = "even";
                    }
                    result = $"{n1} * {n2} = {n1 * n2} - {oddEven}";
                    break;

                case "%":
                    result = $"{n1} % {n2} = {n1 % n2}";
                    break;

                case "/":
                    if(n2 == 0)
                    {
                        result = $"Cannot divide {n1} by zero";
                    }
                    else
                    {
                        result = $"{n1} / {n2} = {(n1 / (n2 * 1.0)):f2}";
                    }
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
