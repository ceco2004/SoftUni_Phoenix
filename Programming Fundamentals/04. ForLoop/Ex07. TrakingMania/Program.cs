using System;

namespace Ex07._TrakingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double allPeople = 0;
            int musalaPeople = 0;
            int monblanPeople = 0;
            int kilimandjaroPeople = 0;
            int k2People = 0;
            int everestPeople = 0;

            for(int i = 0; i < groupCount; i++)
            {
                int people = int.Parse(Console.ReadLine());
                allPeople += people;

                if (people <= 5) musalaPeople += people;
                else if (people <= 12) monblanPeople += people;
                else if (people <= 25) kilimandjaroPeople += people;
                else if (people <= 40) k2People += people;
                else everestPeople += people;

            }

            string msg = string.Empty;
            msg = $"{musalaPeople / allPeople * 100:f2}%";
            msg += $"\n{monblanPeople / allPeople * 100:f2}%";
            msg += $"\n{kilimandjaroPeople / allPeople * 100:f2}%";
            msg += $"\n{k2People / allPeople * 100:f2}%";
            msg += $"\n{everestPeople / allPeople * 100:f2}%";

            Console.WriteLine(msg);
        }
    }
}
