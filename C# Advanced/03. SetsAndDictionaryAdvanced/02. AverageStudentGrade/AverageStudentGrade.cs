using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._AverageStudentGrade
{
    class AverageStudentGrade
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string student = data[0];
                double grade = double.Parse(data[1]);

                if(studentGrades.ContainsKey(student) == false)
                {
                    studentGrades[student] = new List<double>();
                }

                studentGrades[student].Add(grade);
            }

            foreach(var student in studentGrades)
            {
                string grades = string.Empty;
                foreach(var grade in student.Value)
                {
                    grades += $"{grade:f2} ";
                }
                string message = $"{student.Key} -> {grades}(avg: {student.Value.Average():f2})";
                Console.WriteLine(message);
            }
        }
    }
}
