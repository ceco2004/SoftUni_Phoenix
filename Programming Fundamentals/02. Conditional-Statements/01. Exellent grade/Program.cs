using System;

namespace _01._Exellent_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if(grade >= 5.5)
            {
                Console.WriteLine("Exellent!");
            }
        }
    }
}
