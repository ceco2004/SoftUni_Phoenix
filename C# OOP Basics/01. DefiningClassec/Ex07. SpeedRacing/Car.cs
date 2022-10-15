namespace Ex07._SpeedRacing
{
    internal class Car
    {
        public string Model { get; private set; }
        public double FuelAmount { get; private set; }
        public double Consumption { get; private set; }
        public double TraveledDistance { get; private set; }

        internal Car(string model, double fuelAmount, double consumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            Consumption = consumption;
        }

        internal string MoveCar(int distanceToMove)
        {
            string msg = string.Empty;
            if(distanceToMove * Consumption > FuelAmount)
            {
                msg = "Insufficient fuel for the drive";
            }
            else
            {
                FuelAmount -= distanceToMove * Consumption;
                TraveledDistance += distanceToMove;

                msg = $"{Model} was successful moving at {distanceToMove} kilometer/s";
            }


            return msg;
        }

        public override string ToString()
        {
            return $"Car: {Model}, have {FuelAmount:f2} liters fuel, and was moving {TraveledDistance} kilometers.";
        }
    }
}
