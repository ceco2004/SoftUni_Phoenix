using Ex01._PersonProblem.Models;
using System;

namespace Ex01._PersonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ceco", 40);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            Child child = new Child("Ceco", -12);
            Console.WriteLine(child.Name);
            Console.WriteLine(child.Age);
        }
    }
}
