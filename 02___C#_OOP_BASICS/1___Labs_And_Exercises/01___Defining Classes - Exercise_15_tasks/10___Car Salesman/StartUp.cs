using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        var cars = GetCars();
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.Write(car.ToString());
        }
    }

    private static List<Car> GetCars()
    {
        var engines = GetEngines();
        var numOfCars = int.Parse(Console.ReadLine());
        var cars = new List<Car>(numOfCars);
        for (int i = 0; i < numOfCars; i++)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = input[0];
            var engineModel = input[1];
            Engine engine = engines.Where(p => p.Model == engineModel).FirstOrDefault();  
            var currentCar = new Car(model,engine);

            if (input.Length > 2)
            {
                int weight;
                var isDigit = int.TryParse(input[2], out weight);

                if (isDigit)
                {
                    currentCar.Weight = weight;
                }
                else
                {
                    currentCar.Color = input[2];
                }

                if (input.Length > 3)
                {
                    if (isDigit)
                    {
                        currentCar.Color = input[3];
                    }
                    else
                    {
                        currentCar.Weight = int.Parse(input[3]);
                    }
                }
            }
            cars.Add(currentCar);
        }
        return cars;
    }
    private static List<Engine> GetEngines()
    {
        var numOfEngines = int.Parse(Console.ReadLine());
        var enginesList = new List<Engine>(numOfEngines);
        for (int i = 0; i < numOfEngines; i++)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = input[0];
            var power = int.Parse(input[1]);
            var engine = new Engine(model,power);
            enginesList.Add(engine);

            if (input.Length > 2)
            {
                int displacement;
                var isdigit = int.TryParse(input[2], out displacement);

                if (isdigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = input[2];
                }

                if (input.Length > 3)
                {
                    if (isdigit)
                    {
                        engine.Efficiency = input[3];
                    }
                    else
                    {
                        engine.Displacement = int.Parse(input[3]);
                    }
                }
            }
        }
        return enginesList;
    }
}

