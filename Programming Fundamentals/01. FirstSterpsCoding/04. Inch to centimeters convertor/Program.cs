using System;
using System.Threading;

namespace _04._Inch_to_centimeters_convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double inchCoef = 2.54;

            Console.Write("Please input how many inches want to convert: ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inchCoef * inches;

            Console.Write("... converting ");
            for(int i=0; i<3; i++)
            {
                if (i < 2)
                {
                    Console.Write('.');
                    Thread.Sleep(700);
                }
                else
                {
                    Console.WriteLine('.');
                }

            }
            
            Console.WriteLine($"{inches} inches are {centimeters} centimeters");
        }
    }
}
