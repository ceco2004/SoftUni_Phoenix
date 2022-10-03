using System;

namespace Ex09._Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length in centimeters: ");
            double length = double.Parse(Console.ReadLine()) / 10;

            Console.Write("Enter width in centimeters: ");
            double width = double.Parse(Console.ReadLine()) / 10;

            Console.Write("Enter hight in centimeters: ");
            double hight = double.Parse(Console.ReadLine()) / 10;

            Console.Write("Enter percents with sand: ");
            int sandPercent = int.Parse(Console.ReadLine());

            double capacity = length * width * hight;
            double availableCapacity = capacity - capacity * sandPercent / 100;

            Console.WriteLine($"You need {availableCapacity} liters of water.");
        }
    }
}
