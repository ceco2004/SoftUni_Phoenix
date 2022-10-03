using System;

namespace _06._SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double speed = double.Parse(Console.ReadLine());
            string msg = string.Empty;

            if(speed<= 10)
            {
                msg = "slow";
            }
            else if(speed <= 50)
            {
                msg = "average";
            }
            else if(speed <= 150)
            {
                msg = "fast";
            }
            else if(speed <= 1000)
            {
                msg = "ultra fast";
            }
            else
            {
                msg = "extremely fast";
            }

            Console.WriteLine(msg);

        }
    }
}
