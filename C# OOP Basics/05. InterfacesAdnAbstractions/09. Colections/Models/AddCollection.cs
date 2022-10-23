using _09._Colections.Models.Interfaces;
using System.Collections.Generic;

namespace _09._Colections.Models
{
    public class AddCollection <T> : IAddable<T>
    {
        protected IList<T> collection;

        public AddCollection()
        {
            collection = new List<T>();
        }

        public virtual int Add(T item)
        {
            collection.Add(item);
            int lastIndex = collection.Count - 1;
            return lastIndex;
        }
    }
}
