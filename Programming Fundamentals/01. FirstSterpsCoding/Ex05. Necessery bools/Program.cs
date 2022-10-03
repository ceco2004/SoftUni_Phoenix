using System;

namespace Ex05._Necessery_bools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter nubers of pages: ");
            int pages = int.Parse(Console.ReadLine());

            Console.Write("Please enter how many pages read for a hour: ");
            int readeingSpeed = int.Parse(Console.ReadLine());

            Console.Write("Please enter how many days You have to read this book: ");
            int days = int.Parse(Console.ReadLine());

            int hoursPerDay = pages / readeingSpeed / days;

            Console.WriteLine($"You must read {hoursPerDay} hours per day ot read the book in time.");
        }
    }
}
