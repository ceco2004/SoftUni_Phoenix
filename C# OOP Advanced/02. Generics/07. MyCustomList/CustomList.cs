using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._MyCustomList
{
    public class CustomList<T> : ICustomList<T> where T : IComparable<T>
    {
        private readonly IList<T> data;
        public int Count { get => data.Count; }
        public CustomList()
        {
            data = new List<T>();
        }
        public void Add(T element)
        {
            data.Add(element);
        }

        public bool Contains(T element)
        {
            return data.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            return data.Where(e => e.CompareTo(element) > 0).Count();
           
        }

        public T Max()
        {
            return data.Max();
        }

        public T Min()
        {
            return data.Min();
        }

        public T Remove(int index)
        {
            if(index > data.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            T element = data[index];
            data.RemoveAt(index);
            return element;
        }

        public void Swap(int index1, int index2)
        {
            if (index1 > data.Count - 1 || index2 > data.Count - 1 || index1 < 0 || index2 < 0)
            {
                throw new IndexOutOfRangeException();
            }

            T elementOnIndex1 = data[index1];
            data[index1] = data[index2];
            data[index2] = elementOnIndex1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
