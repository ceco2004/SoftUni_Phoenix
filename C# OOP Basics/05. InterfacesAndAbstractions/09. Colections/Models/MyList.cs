using System;
using System.Collections.Generic;

namespace _09._Colections.Models
{
    public class MyList<T> : AddRemoveCollection<T>
    {
        public MyList()
        {
            collection = new List<T>();
        }
        public override T Remove()
        {
            if(collection.Count == 0)
            {
                throw new IndexOutOfRangeException("Collection is empty");
            }
            T element = collection[0];
            collection.RemoveAt(0);
            return element;
        }
    }
}
