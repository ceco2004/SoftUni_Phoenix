using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06._UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> userIpMessages = new SortedDictionary<string, Dictionary<string, int>>();

            while(input != "end")
            {
                AddToLog(input);

                input = Console.ReadLine();
            }

            foreach(var user in userIpMessages)
            {
                string name = user.Key;
                string result = $"{name}: \n";
                foreach(var ip in user.Value)
                {
                    result += $"{ip.Key} => {ip.Value}, ";
                }

                result = result.Remove(result.Length - 2);
                result += ".";

                Console.WriteLine(result);
            }

            


            void AddToLog(string input)
            {

                string[] separatred = input.Split().ToArray();
                string[] ipAddress = separatred[0].Split('=').TakeLast(1).ToArray();
                string[] user = separatred[2].Split('=').TakeLast(1).ToArray();
               
                if(userIpMessages.ContainsKey(user[0]) == false)
                {
                    userIpMessages[user[0]] = new Dictionary<string, int>();
                }

                 if(userIpMessages[user[0]].ContainsKey(ipAddress[0]) == false)
                {
                    userIpMessages[user[0]][ipAddress[0]] = 0;
                }

                userIpMessages[user[0]][ipAddress[0]]++;
            }
        }
    }
}
