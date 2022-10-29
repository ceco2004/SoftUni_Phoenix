using _02._AnimalDoctor.Models.Interfaces;

namespace _02._AnimalDoctor.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string dateOfBirth, IOwner owner = null) : base(name, dateOfBirth, owner)
        {
        }
    }
}

