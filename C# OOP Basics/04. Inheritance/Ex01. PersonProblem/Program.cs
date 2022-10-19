using Ex01._PersonProblem.Models;
using System;

namespace Ex01._PersonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
           
             Person person = new Person("Ceco", 40);
            Console.WriteLine(person);

            Child child = new Child("Ceco", -1);
            Console.WriteLine(child);
        }
    }
}
