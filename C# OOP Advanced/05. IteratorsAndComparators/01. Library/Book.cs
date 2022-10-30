using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _01._Library
{
    public class Book : IBook, IComparable<Book>, IComparer<Book>
    {
        private readonly IList<string> authors;
        public string Title { get; private set; }

        public int Year { get; private set; }

        public IList<string> Authors { get => authors; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            this.authors = new List<string>(authors); 
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }

        public int CompareTo([AllowNull] Book other)
        {
            int result = 0;

            if (Year == other.Year)
            {
                result = Title.CompareTo(other.Title);
            }
            else
            {
                result = Year.CompareTo(other.Year);
            }

            return result;
        }

        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            return x.CompareTo(y);
        }
    }
}
