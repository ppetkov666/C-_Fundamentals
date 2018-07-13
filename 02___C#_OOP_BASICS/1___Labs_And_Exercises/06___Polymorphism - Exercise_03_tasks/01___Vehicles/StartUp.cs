namespace _1.Vehicles
{
    using System;
    public class StartUp
    {
        private const double CarWithACconsumption = 0.9;
        private const double TruckWithACconsumption = 1.6;

        public static void Main()
        {
            var carArgs = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carArgs[1]), 
                              double.Parse(carArgs[2]), 
                              CarWithACconsumption);
            var TruckArgs = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(TruckArgs[1]), 
                                    double.Parse(TruckArgs[2]), 
                                    TruckWithACconsumption);

            ExecuteCommands(car, truck);
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ExecuteCommands(Car car, Truck truck)
        {
            var numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                var action = command[0];
                var vehicleType = command[1];
                var value = double.Parse(command[2]);

                switch (action)
                {
                    case "Drive":
                        Console.WriteLine(vehicleType == "Car"
                            ? car.Drive(value)
                            : truck.Drive(value));
                        break;
                    case "Refuel":
                        switch (vehicleType)
                        {
                            case "Car":
                                car.Refuel(value);
                                break;
                            case "Truck":
                                truck.Refuel(value);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }         
        }
    }
}
