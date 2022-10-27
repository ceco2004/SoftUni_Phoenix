using System;
using System.Collections.Generic;

namespace _01._BoxOfT
{
    public class MyBox<T> : IMyBox<T>
    {
        private readonly IList<T> data;

        public int Count  {get => data.Count;}
        public MyBox()
        {
            data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove()
        {
            int lastIndex = data.Count - 1;
            if(lastIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            T element = data[lastIndex];
            data.RemoveAt(lastIndex);

            return element;
        }
    }
}
