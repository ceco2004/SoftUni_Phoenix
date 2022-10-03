using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04._FixEMail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
         
            Dictionary<string, string> nameEmail = new Dictionary<string, string>();

            while (input != "stop")
            {
                string email = Console.ReadLine();
                if (email.EndsWith(".us")== false && email.EndsWith(".uk") == false)
                {
                    nameEmail[input] = email;
                }

                    input = Console.ReadLine();
            }

            foreach (var pair in nameEmail)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
