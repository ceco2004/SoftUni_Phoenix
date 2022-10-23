using _09._Colections.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace _09._Colections.Models
{
    public class AddRemoveCollection<T> : AddCollection<T>, IRemovable<T>
    {
        public AddRemoveCollection()
        {
            collection = new List<T>();
        }

        public virtual T Remove()
        {
            if (collection.Count == 0)
            {
                throw new IndexOutOfRangeException("Collection is empty");
            }

            int lastIndex = collection.Count - 1;
            T item = collection[lastIndex];
            collection.RemoveAt(lastIndex);
            return item;
        }

        public override int Add(T item)
        {
            int index = 0;
            collection.Insert(index, item);
            return index;
        }
    }
}
