using System;

namespace _07._12Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double gradeAverage = 0;
            bool isExluded = false;
            for(int i = 1; i <= 12; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade <= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {i} grade");
                    isExluded = true;
                    break;
                }
                gradeAverage += grade;
            }
            if (!isExluded)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeAverage / 12:f2}");

            }
        }
    }
}
