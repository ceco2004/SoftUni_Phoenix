using _02._AnimalDoctor.Models.Interfaces;

namespace _02._AnimalDoctor.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string dateOfBirth, IOwner owner = null): base(name, dateOfBirth, owner)
        {

        }
    }
}
