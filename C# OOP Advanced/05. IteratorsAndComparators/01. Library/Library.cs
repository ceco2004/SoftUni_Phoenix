using System.Collections;
using System.Collections.Generic;

namespace _01._Library
{
    public class Library : IEnumerable<Book>
    {
        private IList<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryEnumerator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryEnumerator : IEnumerator<Book>
        {
            private readonly IList<Book> books;
            private int index = -1;
            public LibraryEnumerator(IList<Book> books)
            {
                Reset();
                this.books = books;
            }

            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
