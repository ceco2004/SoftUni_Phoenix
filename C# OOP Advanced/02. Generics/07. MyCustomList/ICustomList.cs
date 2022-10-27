using System;
using System.Collections.Generic;

namespace _07._MyCustomList
{
    public interface ICustomList<T> : IEnumerable<T> where T : IComparable<T>
    {
        int Count { get; }
        void Add(T element);
        T Remove(int index);
        bool Contains(T element);
        void Swap(int index1, int index2);
        int CountGreaterThan(T element);
        T Max();
        T Min();
    }
}
