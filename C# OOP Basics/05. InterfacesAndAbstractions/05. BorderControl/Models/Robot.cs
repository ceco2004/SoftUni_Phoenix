using _05._BorderControl.Models.Interfaces;

namespace _05._BorderControl.Models
{
    public class Robot : ITrackable, IBirtdayble
    {
        public string Id { get; private set; }
        public string Model { get; private set; }
        public string Birthday { get; }

        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }
    }
}
