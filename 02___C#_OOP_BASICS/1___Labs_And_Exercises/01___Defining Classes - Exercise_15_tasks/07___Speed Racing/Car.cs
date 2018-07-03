
class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKm;
    private double distanceTravelled;
    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        this.distanceTravelled = 0.0;
    }

    public string Model
    {
        get { return model; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
    }

    public double DistanceTravelled
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

    public void Drive(double kilometers)
    {
        var neededFuel = kilometers * fuelConsumptionPerKm;

        if (fuelAmount < neededFuel)
        {
            System.Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        fuelAmount -= neededFuel;
        distanceTravelled += kilometers;
    }
}

