using System.Collections.Generic;
using System.Linq;

namespace Ex01._DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public List<Person> Members
        {
            get => members;
            set => members = value;
        }

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOdestMember()
        {
            return members.OrderByDescending(m => m.Age).First();
        }
    }
}
