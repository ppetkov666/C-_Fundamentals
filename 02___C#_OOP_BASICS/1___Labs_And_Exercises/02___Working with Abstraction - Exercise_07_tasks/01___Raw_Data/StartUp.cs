using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        List<Car> cars = GetFullListOfCars();
        PrintOutputCars(cars);
    }
    private static void PrintOutputCars(List<Car> cars)
    {
        var lastCommand = Console.ReadLine();
        if (lastCommand == "fragile")
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars
                .Where(p => p.Cargo.Type == "fragile" && p.Tires.Any(t => t.Presure < 1))
                .Select(m => m.Model)));          
        }
        else
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars
                .Where(p => p.Engine.Power > 250)
                .Select(q=>q.Model)));
        }
    }

    private static List<Car> GetFullListOfCars()
    {
        List<Car> cars = new List<Car>();
        int numberOfcars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfcars; i++)
        {
            var splittedInput = Console.ReadLine().Split();
            var model = splittedInput[0];
            var engineSpeed = int.Parse(splittedInput[1]);
            var enginePower = int.Parse(splittedInput[2]);
            var cargoWeight = int.Parse(splittedInput[3]);
            var cargoType = splittedInput[4];
            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            var tires = new List<Tire>(4);
            for (int tireCount = 0; tireCount < 4; tireCount++)
            {
                int presure = 5;
                int age = 6;
                tires.Add(new Tire(double.Parse(splittedInput[presure]), int.Parse(splittedInput[age])));
                presure++;
                age++;
            }
            cars.Add(new Car(model, engine, cargo, tires));
        }
        return cars;
    }
}

