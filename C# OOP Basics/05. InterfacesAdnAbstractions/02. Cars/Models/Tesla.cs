using _02._Cars.Models.Interfaces;

namespace _02._Cars.Models
{
    public class Tesla : ICar, IElectricCar
    {
        public int Battery { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
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
            return $"{Color} {GetType().Name} {Model} with {Battery} batteries ";
        }
    }
}
