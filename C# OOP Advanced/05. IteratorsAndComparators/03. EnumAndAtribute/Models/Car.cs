namespace _03._EnumAndAtribute.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public EngineType EngineType { get; set; }

        public override string ToString()
        {
            return $"{Brand} model {Model} in {Color} is driven by {EngineType}. ";
        }
    }
}
