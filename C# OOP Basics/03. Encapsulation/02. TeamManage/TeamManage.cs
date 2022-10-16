using _01._SortByNameAndAge.Models;
using _02._TeamManage.Models;
using System;
using System.Collections.Generic;

namespace _02._TeamManage
{
    public class TeamManage
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            var bonus = decimal.Parse(Console.ReadLine());

            try
            {
                persons.ForEach(p => p.IncreaseSalary(bonus));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Team team = new Team("SoftUni");

            persons.ForEach(p => team.AddPlayer(p));

            
            Console.WriteLine(team);
        }
    }
}
