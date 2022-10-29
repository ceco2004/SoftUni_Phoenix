using _02._AnimalDoctor.Models.Interfaces;

namespace _02._AnimalDoctor.Models
{
    public class Dog : Animal
    {
        public Dog(string ID, string name, string dateOfBirth, IOwner owner = null) : base(ID, name, dateOfBirth, owner)
        {
        }
    }
}

