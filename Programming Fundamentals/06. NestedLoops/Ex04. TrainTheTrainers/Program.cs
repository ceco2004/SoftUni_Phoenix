using System;

namespace Ex04._TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jourey = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double gradeAll = 0;
            int coursCounter = 0;

            while(input != "Finish")
            {
                string course = input;
                coursCounter++;
                double grade = 0;
                for(int i = 0; i < jourey; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                }
                gradeAll += grade /jourey;
                Console.WriteLine($"{course} - {grade / jourey :f2}.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {gradeAll / coursCounter :f2}.");
        }
    }
}
