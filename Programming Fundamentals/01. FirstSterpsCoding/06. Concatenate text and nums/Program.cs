using System;

namespace _06._Concatenate_text_and_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input Your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please input Your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please input Yours age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter the town You are where from: ");
            string town = Console.ReadLine();

            string template = $"You are {firstName} {lastName}, a {age}-years old person from {town}.";

            Console.WriteLine(template);
        }
    }
}
