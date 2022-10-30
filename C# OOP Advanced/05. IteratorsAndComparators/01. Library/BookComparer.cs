using System.Diagnostics.CodeAnalysis;

namespace _01._Library
{
    public class BookComparer : IBookComparer
    {
        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            return x.CompareTo(y);
        }
    }
}
