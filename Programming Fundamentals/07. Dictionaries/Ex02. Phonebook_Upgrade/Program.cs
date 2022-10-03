using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A": AddToBook(input[1], input[2]); break;
                    case "S": Console.WriteLine(SearchName(input[1])); ; break;
                    case "ListAll":PrintBook(phonebook); break;
                        
                }

                input = Console.ReadLine().Split().ToArray();
            }

            void PrintBook(SortedDictionary<string, string> phonebook)
            {
                foreach(var contact in phonebook)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
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
