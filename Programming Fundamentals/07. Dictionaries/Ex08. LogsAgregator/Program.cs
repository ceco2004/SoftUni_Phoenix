using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex08._LogsAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> nameAddressCount = 
                new SortedDictionary<string, SortedDictionary<string, int>>();

            for(int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                AddData(input);
            }

            foreach(var user in nameAddressCount)
            {
                int totalTime = user.Value.Values.Sum();
                Console.WriteLine($"{user.Key}: {totalTime} [{string.Join(", ", user.Value.Keys)}]");
            }


            void AddData(string[] data)
            {
                string ip = data[0];
                string name = data[1];
                int time = int.Parse(data[2]);

                if(nameAddressCount.ContainsKey(name) == false)
                {
                    nameAddressCount[name] = new SortedDictionary<string, int>();
                }

                if(nameAddressCount[name].ContainsKey(ip) == false)
                {
                    nameAddressCount[name][ip] = 0;
                }

                nameAddressCount[name][ip] += time;
            }
        }
    }
}
