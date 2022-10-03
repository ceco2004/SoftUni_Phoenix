using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07._PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> countryCityPopulation = new Dictionary<string, Dictionary<string, int>>();


            while(input != "report")
            {
                AddData(input);

                input = Console.ReadLine();
            }


            foreach(var country in countryCityPopulation.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach(var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=> {city.Key}: {city.Value}");
                }
            }


            void AddData(string input)
            {
                string[] data = input.Split('|').ToArray();
                string city = data[0];
                string country = data[1];
                int population = int.Parse(data[2]);

                if(countryCityPopulation.ContainsKey(country) == false)
                {
                    countryCityPopulation[country] = new Dictionary<string, int>();
                }

                if(countryCityPopulation[country].ContainsKey(city) == false)
                {
                    countryCityPopulation[country][city] = 0;
                }

                countryCityPopulation[country][city] += population;


            }
        }
    }
}
