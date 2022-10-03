using System;

namespace _07._Architect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter architect name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter numbers of projects: ");
            int projects = int.Parse(Console.ReadLine());

            int time = projects * 3;
            string template = $"The architect {name} will need {time} hours to complete {projects} project/s.";
            Console.WriteLine(template);
        }
    }
}
