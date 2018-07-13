namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        private double amountOfFuel;
        private double fuelConsumption;
        private double aCCOnsumption;

        public Vehicle(double amountOfFuel, double fuelConsumption, double aCCOnsumption)
        {
            this.AmountOfFuel = amountOfFuel;
            this.FuelConsumption = fuelConsumption;
            this.ACCOnsumption = aCCOnsumption;
        }
        public double AmountOfFuel { get; set; }

        public double FuelConsumption { get; set; }

        public double ACCOnsumption { get; set; }

        public virtual void Refuel(double fuel)
        {
            this.AmountOfFuel += fuel;
        }

        public string Drive(double distance)
        {
            var neededFuel = (this.FuelConsumption + this.ACCOnsumption) * distance;

            if (neededFuel > this.AmountOfFuel)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.AmountOfFuel -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.AmountOfFuel:F2}";
        }
    }
}
