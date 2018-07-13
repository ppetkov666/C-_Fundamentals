using System;
public class StartUp
{
    static void Main()
    {
        var carArgs = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carArgs[1]), 
                              double.Parse(carArgs[2]), 
                              double.Parse(carArgs[3]));

        var truckArgs = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckArgs[1]), 
                                  double.Parse(truckArgs[2]), 
                                  double.Parse(truckArgs[3]));

        var busArgs = Console.ReadLine().Split();
        Vehicle bus = new Bus(double.Parse(busArgs[1]), 
                              double.Parse(busArgs[2]), 
                              double.Parse(busArgs[3]));

        var numOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfCommands; i++)
        {
            var commandArgs = Console.ReadLine().Split();
            var command = commandArgs[0];
            var typeOfVehicle = commandArgs[1];
            var givenParam = double.Parse(commandArgs[2]);

            Vehicle vehicleToOperate;
            if (typeOfVehicle == "Car")
                vehicleToOperate = car;
            else if (typeOfVehicle == "Truck")
                vehicleToOperate = truck;
            else
                vehicleToOperate = bus;

            try
            {
                switch (command)
                {
                    case "Drive":
                        vehicleToOperate.Drive(givenParam);
                        Console.WriteLine($"{vehicleToOperate.GetType().Name} travelled {givenParam} km");
                        break;
                    case "DriveEmpty":
                        ((Bus)vehicleToOperate).DriveEmpty(givenParam);
                        Console.WriteLine($"{vehicleToOperate.GetType().Name} travelled {givenParam} km");
                        break;
                    case "Refuel":
                        vehicleToOperate.Refuel(givenParam);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}
