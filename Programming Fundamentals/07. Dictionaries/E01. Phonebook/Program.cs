using System;
using System.Collections.Generic;
using System.Linq;

namespace E01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split().ToArray();

            while(input[0] != "END")
            {
                switch (input[0])
                {
                    case "A": AddToBook(input[1], input[2]); break;
                    case "S": Console.WriteLine(SearchName(input[1])); ; break;
                }

                input = Console.ReadLine().Split().ToArray();
            }

            string SearchName(string name)
            {
                string msg = string.Empty;
                if (phonebook.ContainsKey(name))
                {
                    msg = $"{name} -> {phonebook[name]}";
                }
                else
                {
                    msg = $"Contact {name} does not exist.";
                }

                return msg;
            }

             void AddToBook(string name, string phone)
            {
                phonebook[name] = phone;
            }
        }
    }
}
