using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _01._Library
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            return x.CompareTo(y);
        }
    }
}
