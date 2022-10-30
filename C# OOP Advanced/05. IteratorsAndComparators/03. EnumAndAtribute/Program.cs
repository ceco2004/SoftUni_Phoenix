using _03._EnumAndAtribute.Models;
using System;

namespace _03._EnumAndAtribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Tesla";
            car.Model = "S";
            car.Color = Color.Red;
            car.EngineType = EngineType.Electric;
            Console.WriteLine(car);

           
        }
    }
}
