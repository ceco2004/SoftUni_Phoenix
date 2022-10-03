using System;

namespace Ex02._Radian_to_Gradus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input radians: ");
            double radians = double.Parse(Console.ReadLine());
            Console.WriteLine($"{radians} radians are {radians*180/Math.PI} gradus");
        }
    }
}
