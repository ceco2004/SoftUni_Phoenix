using System;

namespace Ex04._Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            bool isTired = false;


            while (goal > 0)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    goal -= lastSteps;
                    isTired = true;
                    break;
                }
                else
                {
                    goal -= int.Parse(input);
                }
            }

            string msg = string.Empty;

            if (isTired && goal > 0)
            {
                msg = $"{goal} more steps to reach goal.";
            }
            else
            {
                msg = "Goal reached! Good job!";
                msg += $"\n{Math.Abs(goal)} steps over the goal!";
            }


            Console.WriteLine(msg);
        }
    }
}
