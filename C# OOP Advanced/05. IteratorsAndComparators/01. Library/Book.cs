using System.Collections.Generic;

namespace _01._Library
{
    public class Book : IBook
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
            return Title;
        }
    }
}
