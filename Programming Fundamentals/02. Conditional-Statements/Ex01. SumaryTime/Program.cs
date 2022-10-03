using System;

namespace Ex01._SumaryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int tirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + tirdTime;

            int minutes = totalTime / 60;
            int sec = totalTime % 60;

            string minAsString = minutes.ToString();
            if (minAsString.Length == 1)
            {
                minAsString = "0" + minAsString;
            }

            string secAsString = sec.ToString();
            if(secAsString.Length == 1)
            {
                secAsString = "0" + secAsString;
            }

            Console.WriteLine($"{minAsString}:{secAsString}");
        }
    }
}
