using System.Collections.Generic;

namespace _01._Library
{
    public interface IBook
    {
        string Title { get; }
        int Year { get; }
        IList<string> Authors { get; }
    }
}
