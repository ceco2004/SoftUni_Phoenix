using System;

namespace Ex03._TimePlus15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            //var time = DateTime.Parse($"{hour.ToString()}:{min.ToString()}");
            //time = time.AddMinutes(15);
            //Console.WriteLine($"{time.Hour}:{time.Minute}");

            min += 15;
            hour += min / 60;
            hour = hour % 24;
            min = min % 60;

            string hourAsString = hour.ToString();
            string minAsString = min.ToString();

            if(minAsString.Length == 1)
            {
                minAsString = "0" + minAsString;
            }

            Console.WriteLine($"{hourAsString}:{minAsString}");

        }
    }
}
