using System;

namespace _06._NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = string.Empty;

            if(num >= -100 && num <= 100 && num != 0)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }
            Console.WriteLine(result);
        }
    }
}
