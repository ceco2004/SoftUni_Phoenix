namespace Ex10._CarSalesMan.Models
{
    internal class Engine
    {
        internal string Model { get; set;}
        internal int Power { get; set; }
        internal int Displacement { get; set; }
        internal string Efficiency { get; set; }

        private string ChekIsZero(string data)
        {
            return data == "0" || data == string.Empty ? "n/a" : data;
        }
        public override string ToString()
        {
            string result = string.Empty;

            result += $" {Model}:";
            result += $"\n     Power: {ChekIsZero(Power.ToString())}";
            result += $"\n     Displacement: {ChekIsZero(Displacement.ToString())}";
            result += $"\n     Efficiency: {ChekIsZero(Efficiency)}";

            return result;
        }
    }
}
