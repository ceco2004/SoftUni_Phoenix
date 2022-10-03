using System;

namespace Ex02._ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumPoorGrade = int.Parse(Console.ReadLine());
            int poorGradeCounter = 0;
            int gradeCounter = 0;
            int gradeSum = 0;
            string lastProblemName = string.Empty;

            while (poorGradeCounter < maximumPoorGrade)
            {
                string problemName = Console.ReadLine();

                if(problemName == "Enough")
                {
                    break;
                }
                lastProblemName = problemName;

                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                gradeCounter++;
                if(grade<= 4)
                {
                    poorGradeCounter++;
                }
            }

            string msg = string.Empty;

            if(poorGradeCounter < maximumPoorGrade)
            {
                msg = $"Average score: {gradeSum * 1.0 / gradeCounter:f2}";
                msg += $"\nNumber of problems: {gradeCounter}";
                msg += $"\nLast problem: {lastProblemName}";
            }
            else
            {
                msg = $"You need a break, {poorGradeCounter} poor grades.";
            }

            Console.WriteLine(msg);
        }
    }
}
