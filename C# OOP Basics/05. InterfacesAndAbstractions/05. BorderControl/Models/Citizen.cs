using _05._BorderControl.Models.Interfaces;

namespace _05._BorderControl.Models
{
    public class Citizen : ITrackable, IBirtdayble
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthday { get; private set; }

        public Citizen(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Citizen(string id, string name, int age, string birthday)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthday = birthday;
        }
    }
}
