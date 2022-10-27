using System;
using System.Collections.Generic;
using System.Text;

namespace _01._BoxOfT
{
    public interface IMyBox<T>
    {
        int Count { get; }
        void Add(T element);
        T Remove();
    }
}
