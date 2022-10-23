using _05._BorderControl.Models.Interfaces;

namespace _05._BorderControl.Models
{
    public class Pet : IBirtdayble
    {
        public string Name { get; private set; }
        public string Birthday { get; private set; }

        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
