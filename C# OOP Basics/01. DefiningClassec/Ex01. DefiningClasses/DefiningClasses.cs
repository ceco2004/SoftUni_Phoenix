using System;
using RandomNameGeneratorLibrary;

namespace Ex01._DefiningClasses
{
    class DefiningClasses
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            
            Random rd = new Random();

            for(int i = 0; i <= 100; i++)
            {
                int age = rd.Next(10, 99);
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
            Console.WriteLine(oldest);
        }
    }
}
