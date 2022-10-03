using System;

namespace Ex01._OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string noMoreBooks = "No More Books";
            int bookCounter = 0;
            string currentBook = Console.ReadLine();

            while(currentBook != searchedBook && currentBook != noMoreBooks)
            {
                bookCounter++;
                currentBook = Console.ReadLine();
            }

            bool isFinded = false;
            if(currentBook == searchedBook)
            {
                isFinded = true;
            }
            string msg = string.Empty;

            if (isFinded)
            {
                msg = $"You checked {bookCounter} books and found it.";
            }
            else
            {
                msg = "The book you search is not here!";
                msg += $"\nYou checked {bookCounter} books.";
            }

            Console.WriteLine(msg);
        }
    }
}
