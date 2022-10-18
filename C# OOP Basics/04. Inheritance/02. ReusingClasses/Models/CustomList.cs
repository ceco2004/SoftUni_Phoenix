using System;
using System.Collections.Generic;
using System.Text;

namespace _02._ReusingClasses.Models
{
    internal class CustomList : List<int>
    {
        private const string emptyMsg = "The CustomList is Empty!";
        private List<string> list;

        public CustomList()
        {
            list = new List<string>();
        }

        public void Push(string item)
        {
            list.Add(item);
        }

        public string Pop()
        {
            if (this.IsEmpy())
            {
                throw new ArgumentException(emptyMsg);
            }
            int lastIndex = list.Count - 1;
            string data = list[lastIndex];
            list.RemoveAt(lastIndex);

            return data;
        }

        public string Peek()
        {
            if (this.IsEmpy())
            {
                throw new ArgumentException(emptyMsg);
            }
            return list[list.Count - 1];
        }

        public bool IsEmpy()
        {
            return list.Count < 1;
        }
    }

}
