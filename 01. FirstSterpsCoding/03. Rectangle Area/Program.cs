using System;

namespace _03._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input length on one side: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please input lenght on other side: ");
            int b = int.Parse(Console.ReadLine());

            int area = a * b;
            Console.WriteLine($"Rectangle area is: {area}");
        }
    }
}
