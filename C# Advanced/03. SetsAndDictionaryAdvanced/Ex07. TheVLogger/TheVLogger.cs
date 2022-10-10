using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07._TheVLogger
{
    class TheVLogger
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> vlogerFollowers = new Dictionary<string, List<string>>();
            Dictionary<string, int> vlogerFollowing = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while(input != "Statistics")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[1])
                {
                    case "joined":
                        string name = data[0];
                        if(vlogerFollowers.ContainsKey(name)== false)
                        {
                            vlogerFollowers[name] = new List<string>();
                            vlogerFollowing[name] = 0;
                        }
                        break;
                    case "followed":
                        string vloger = data[0];
                        string posledvan = data[2];

                        if(vloger != posledvan)
                        {
                            if (vlogerFollowers.ContainsKey(posledvan)
                                && vlogerFollowers[posledvan].Contains(vloger) == false
                                && vlogerFollowing.ContainsKey(vloger))
                            {
                                vlogerFollowers[posledvan].Add(vloger);
                                vlogerFollowing[vloger]++;
                            }

                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vlogerFollowing.Count} vloggers in its logs.");

            int count = 0;

            foreach(var vl in vlogerFollowers.OrderByDescending(x => x.Value.Count))
            {
                string name = vl.Key;
                int following = vlogerFollowing[name];
                Console.WriteLine($"{++count}. {name} : {vl.Value.Count} followers, {following} following");
                if(count == 1)
                {
                    foreach(string n in vl.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"* {n}");
                    }
                }
            }
        }
    }
}
