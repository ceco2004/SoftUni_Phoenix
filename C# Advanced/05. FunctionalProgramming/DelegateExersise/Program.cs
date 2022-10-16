using System;

namespace DelegateExersise
{
    public delegate string Calculation(int x, int y);
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Calculator(1, 2, Add));
            Console.WriteLine(Calculator(10, 100, Multy));
            Console.WriteLine(Calculator(10, 100, Divide));


        }

        public static string Calculator(int x, int y, Calculation calc)
        {
            return calc(x, y);
        }

        public static string Substraction(int x, int y)
        {
            return (x - y).ToString();
        }

        public static string Divide(int x, int y)
        {
            return ((double)x / y).ToString();
        }

        public static string Multy(int x, int y)
        {
            return (x * y).ToString();
        }

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
