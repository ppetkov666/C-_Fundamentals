namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        private const double TotalFuelAfterFIllTheTank = 0.95;

        public Truck(double AmountOfFuel, double fuelConsumption, double aCCOnsumption) 
            : base(AmountOfFuel, fuelConsumption, aCCOnsumption)
        {
        }

        public override void Refuel(double fuel)
        {
            fuel *= TotalFuelAfterFIllTheTank;
            base.Refuel(fuel);
        }
    }
}
