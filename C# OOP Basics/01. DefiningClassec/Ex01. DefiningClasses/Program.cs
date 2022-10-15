using System;
using System.Linq;
using RandomNameGeneratorLibrary;

namespace Ex01._DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            
            Random rd = new Random();

            int personCount = int.Parse(Console.ReadLine());

            for(int i = 0; i < personCount; i++)
            {
                int age = rd.Next(30, 99);
                string name = string.Empty;

                if(i % 2 == 0)
                {
                    name = RandomPersonNameExtensions.GenerateRandomFirstName(rd);
                }
                else
                {
                    name = RandomPersonNameExtensions.GenerateRandomMaleFirstName(rd);
                }

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldest = family.GetOdestMember();
            Console.WriteLine($"The oldest person is: {oldest}");

            foreach(var person in family.Members.OrderBy(p => p.Name))
            {
                Console.WriteLine(person);
            }

            DateModifier dm = new DateModifier("1992 05 31", "2016 06 17");
            Console.WriteLine(dm.Diffrence);
        }
    }
}
