using System;
using System.Text;

namespace Ex03._Mankind.Models
{
    public class Worker : Human
    {
        private const string salaryErr = "Expected value mismatch! Argument: Salary";
        private const string workHoursErr = "Expected value mismatch! Argument: workHoursPerDay";


        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary { get => weekSalary; set => weekSalary = ValidateSalary(value); }
        public int WorkHoursPerDay { get => workHoursPerDay; set => workHoursPerDay = ValidateWorkHoursPerDay(value); }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Week Salary: {WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {WorkHoursPerDay}");
            sb.AppendLine($"Salary per Hour: {HourlyRate():f2}");
            return sb.ToString();
        }

        public decimal HourlyRate()
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }

        private int ValidateWorkHoursPerDay(int hours)
        {
            if(hours < 1 || hours > 12)
            {
                throw new ArgumentException(workHoursErr);
            }
            return hours;
        }

        private decimal ValidateSalary(decimal salary)
        {
            if(salary < 10)
            {
                throw new ArgumentException(salaryErr);
            }
            return salary;
        }
    }
}
