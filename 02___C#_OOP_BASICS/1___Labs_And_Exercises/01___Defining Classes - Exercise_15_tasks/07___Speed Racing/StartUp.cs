using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    private static object cars;

    public static void Main()
    {
        List<Car> cars = ReadAllCars();
        DriveCars(cars);
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        Console.WriteLine(string.Join(Environment.NewLine, cars
            .Select(p => $"{p.Model} {p.FuelAmount:F2} {p.DistanceTravelled}")));
    }

    private static void DriveCars(List<Car> cars)
    {
        var command = Console.ReadLine().Split();
       
        while (command[0] != "End")
        {
            var carmodel = command[1];
            var amountOfKm = command[2];
            var currentCar = cars.Where(p => p.Model == carmodel).FirstOrDefault();

            if (currentCar != null)
            {
                currentCar.Drive(double.Parse(amountOfKm));
            }
            command = Console.ReadLine().Split();
        }
    }

    private static List<Car> ReadAllCars()
    {
        var cars = new List<Car>();
        var numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            var input = Console.ReadLine().Split();
            var model = input[0];
            var fuelamount = double.Parse(input[1]);
            var fuelconsumption = double.Parse(input[2]);
            Car car = new Car(model, fuelamount, fuelconsumption);
            cars.Add(car);
        }
        return cars;
    }
}

