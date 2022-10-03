using System;

namespace Ex08._LunchOff
{
    class Program
    {
        static void Main(string[] args)
        {
            string episode = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int brakeLength = int.Parse(Console.ReadLine());

            double lunchTime = brakeLength / 8.0;
            double offTime = brakeLength / 4.0;

            double allNeededTime = episodeLength + lunchTime + offTime;

            double absTime = brakeLength - allNeededTime;

            string msg = string.Empty;

            if(absTime >= 0)
            {
                msg = $"You have enough time to watch {episode} and left with {Math.Ceiling(absTime)} minutes free time.";
            }
            else
            {
                msg = $"You don't have enough time to watch {episode}, you need {Math.Ceiling(Math.Abs(absTime))} more minutes.";
            }

            Console.WriteLine(msg);
        }
    }
}
