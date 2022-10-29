using System.Collections.Generic;

namespace _02._AnimalDoctor.Models.Interfaces
{
    public interface IOwner
    {
        string FirstName { get; }
        string LastName { get; }
        string Email { get; }
        string Phone { get; }
        string Address { get; }
        IList<IAnimal> Animals { get; }

        bool ChangeEmail(string email);
        bool ChangePhone(string phone);
        bool AddAnimal(IAnimal animal);
        IAnimal RemoveAnimal(IAnimal animal);

    }
}
