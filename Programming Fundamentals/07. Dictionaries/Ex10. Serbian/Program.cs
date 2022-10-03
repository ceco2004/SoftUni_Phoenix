using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex10._Serbian
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> placeSingerMoney 
                = new Dictionary<string, Dictionary<string, double>>();

            while (input != "End")
            {
                AddData(input);

                input = Console.ReadLine();
            }

            foreach(var place in placeSingerMoney)
            {
                Console.WriteLine(place.Key);
                foreach(var singer in place.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }


            void AddData(string data)
            {
                Regex rx = new Regex(@"([A-z]*|[A-z]* [A-z]*) @([A-z]*|[A-z]+ [A-z]*) ([0-9]*) ([0-9]*)");
                Match match = rx.Match(data);

                GroupCollection group = match.Groups;
                if(group.Count == 5)
                {
                    string singer = group[1].ToString();
                    string city = group[2].ToString();
                    double ticketPrice = double.Parse(group[3].ToString());
                    int places = int.Parse(group[4].ToString());

                    if (placeSingerMoney.ContainsKey(city) == false)
                    {
                        placeSingerMoney[city] = new Dictionary<string, double>();
                    }

                    if (placeSingerMoney[city].ContainsKey(singer) == false)
                    {
                        placeSingerMoney[city][singer] = 0;
                    }

                    placeSingerMoney[city][singer] += places * ticketPrice;
                }

            }
        }
    }
}
