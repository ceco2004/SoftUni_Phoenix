using _02._Cars.Models.Interfaces;

namespace _02._Cars.Models
{
    public class Seat : ICar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Start()
        {
            return $"{this.GetType().Name}-s engine start...";
        }

        public string Stop()
        {
            return $"{this.GetType().Name}-s engine stop...";
        }

        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model}";
        }
    }
}
