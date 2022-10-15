namespace Ex10._CarSalesMan.Models
{
    internal class Car
    {

        internal string Model { get; set; }
        internal Engine Engine { get; set; }
        internal int Weight { get; set; }
        internal string Color { get; set; }

        private string CheckIfIsZeroOrEmpty(string input)
        {
            return input == "0" || input == string.Empty ? "n/a" : input;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += $"{Model}:";
            result += $"\n {Engine.ToString()}";
            result += $"\n  Weight: {CheckIfIsZeroOrEmpty(Weight.ToString())}";
            result += $"\n  Efficiency: {CheckIfIsZeroOrEmpty(Engine.Efficiency)}";

            return result;
        }
    }
}
