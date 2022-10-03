using System;

namespace Ex06._WordSwimmRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double moreTimeCoef = Math.Floor(distance /15);
            double moreTime = moreTimeCoef * 12.5;
            double time = distance * speed;
            double totalTime = time + moreTime;

            string msg = string.Empty;

            if(totalTime < record)
            {
                msg = $" Yes, he succeeded!The new world record is {totalTime:F2} seconds.";
            }
            else
            {
                msg = $"No, he failed! He was {(totalTime - record):f2} seconds slower.";
            }

            Console.WriteLine(msg);
        }
    }
}
