using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> invitedGuests = new HashSet<string>();

            InvitingGuests(invitedGuests);

            CommingGuests(invitedGuests);

            PrintWhoIsntCome(invitedGuests);
        }

        private static void PrintWhoIsntCome(HashSet<string> invitedGuests)
        {
            Console.WriteLine(invitedGuests.Count);
            Console.Write(string.Join("\n", invitedGuests.Where(n => char.IsDigit(n[0]))));
            Console.Write(string.Join("\n", invitedGuests.Where(n => char.IsDigit(n[0]) == false)));
        }

        private static void CommingGuests(HashSet<string> invitedGuests)
        {
            string input = Console.ReadLine();

            while(input != "END")
            {
                invitedGuests.Remove(input);

                input = Console.ReadLine();
            }
        }


        private static void InvitingGuests(HashSet<string> invitedGuests)
        {
            string input = Console.ReadLine();

            while(input != "PARTY")
            {
                invitedGuests.Add(input);

                input = Console.ReadLine();
            }
        }
    }
}
