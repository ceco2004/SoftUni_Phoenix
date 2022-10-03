using System;

namespace Ex08._ExamOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());

            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinutes = int.Parse(Console.ReadLine());

            int examUnitime = examHour * 60 + examMinutes;
            int arrivingUniTime = arrivingHour * 60 + arrivingMinutes;

            int difrenceTime = arrivingUniTime - examUnitime;

            string timeAsString = string.Empty;

            int difrensHours = Math.Abs(difrenceTime) / 60;
            int difrenceMinutes = Math.Abs(difrenceTime) % 60;

            if(difrenceTime == 0)
            {
                if(difrenceMinutes < 10)
                {
                    timeAsString = $"0{difrenceMinutes}";
                }
                else
                {
                    timeAsString = $"{difrenceMinutes}";
                }
            }
            else
            {
                if(difrensHours != 0)
                {
                    if (difrenceMinutes < 10)
                    {
                        timeAsString = $"{difrensHours}:0{difrenceMinutes} hours";
                    }
                    else
                    {
                        timeAsString = $"{difrensHours}:{difrenceMinutes} hours";
                    }
                }
                else
                {
                    if (difrenceMinutes < 10)
                    {
                        timeAsString = $"0{difrenceMinutes} minutes";
                    }
                    else
                    {
                        timeAsString = $"{difrenceMinutes} minutes";
                    }
                }

                
            }

            if(difrenceTime <= 0 && difrenceTime >= -30)
            {
                Console.WriteLine("On time");
                if(difrenceMinutes != 0)
                {
                    Console.WriteLine($"{difrenceMinutes} minutes before the start");
                }
            }
            else if(difrenceTime < -30)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{timeAsString} before the start");
            }
            else if( difrenceTime > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{timeAsString} after the start");
            }
        }
    }
}
