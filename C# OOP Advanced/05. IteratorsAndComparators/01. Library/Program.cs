﻿using System;
using System.Collections.Generic;

namespace _01._Library
{
    public class Program
    {
        static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            SortedSet<Book> books = new SortedSet<Book>(libraryTwo, new BookComparer());

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }


        }
    }
}
