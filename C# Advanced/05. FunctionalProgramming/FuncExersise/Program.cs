using System;

namespace FuncExersise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculator(5, 10, DelegateExersise.Program.Add));
            Console.WriteLine(Calculator(20, 200, DelegateExersise.Program.Divide));

        }


        public static string Calculator(int x, int y, Func<int, int, string> fn )
        {
            return fn(x, y);
        }
    }
}
