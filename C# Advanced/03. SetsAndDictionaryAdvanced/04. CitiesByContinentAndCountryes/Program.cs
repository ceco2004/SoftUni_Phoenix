using System;
using System.Collections.Generic;

namespace _04._CitiesByContinentAndCountryes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continentCountryCities
                = new Dictionary<string, Dictionary<string, List<string>>>();

            FilltTheData(n, continentCountryCities);

            Print(continentCountryCities);

        }

        private static void Print(Dictionary<string, Dictionary<string, List<string>>> continentCountryCities)
        {
            foreach(var continent in continentCountryCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }

        private static void FilltTheData(int n, Dictionary<string, Dictionary<string, List<string>>> continentCountryCities)
        {
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if (continentCountryCities.ContainsKey(continent) == false)
                {
                    continentCountryCities[continent] = new Dictionary<string, List<string>>();
                }

                if (continentCountryCities[continent].ContainsKey(country) == false)
                {
                    continentCountryCities[continent][country] = new List<string>();
                }

                continentCountryCities[continent][country].Add(city);
            }
        }
    }
}
