using System;
using System.Text;

namespace Ex03._Mankind.Models
{
    public class Student : Human
    {
        private const string invalidFacultyNumErr = "Invalid faculty number!";
        private string facultyNum;

        public string FacultyNum { get => facultyNum; set => facultyNum = ValidateFacultyNum(value); }

        public Student(string firstName, string lastName, string facultyNum) : base(firstName, lastName)
        {
            FacultyNum = facultyNum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Faculty Number: {FacultyNum}");
            return sb.ToString();
        }

        private string ValidateFacultyNum(string facultyNum)
        {
            int length = facultyNum.Length;
            if(length < 5 || length > 10)
            {
                throw new ArgumentException(invalidFacultyNumErr);
            }
            return facultyNum;
        }
    }
}
