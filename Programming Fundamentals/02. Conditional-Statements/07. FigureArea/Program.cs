using System;

namespace _07._FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = double.NaN;
            double a = double.NaN;
            double b = double.NaN;

            switch (figure)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;

                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = a * b;
                    break;

                case "circle":
                    a = double.Parse(Console.ReadLine());
                    area = Math.PI * a * a;
                    break;

                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = a * b / 2;
                    break;

                default: 
                    break;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
