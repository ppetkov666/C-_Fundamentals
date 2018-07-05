using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var cars = GetCars();
        PrintCars(cars);
    }
    private static void PrintCars(List<Car>cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
    private static List<Car> GetCars()
    {
        var engines = GetEngines();
        var numOfCars = int.Parse(Console.ReadLine());
        var listOfCars = new List<Car>(numOfCars);
        for (int i = 0; i < numOfCars; i++)
        {
            var splittedInput = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var carModel = splittedInput[0];
            var carEngine = splittedInput[1];         
            Engine engine = engines.Where(e => e.Model == carEngine).FirstOrDefault();
            var car = new Car(carModel, engine);
            if (splittedInput.Length > 2)
            {
                double weight;
                bool isDigit = double.TryParse(splittedInput[2], out weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = splittedInput[2];
                }
                if (splittedInput.Length > 3 )
                {
                    if (isDigit)
                    {
                        car.Color = splittedInput[3];
                    }
                    else
                    {
                        car.Weight = double.Parse(splittedInput[3]);
                    }
                }
            }
            listOfCars.Add(car);
        }
        return listOfCars;
    }

    private static List<Engine> GetEngines()
    {
        var numofEngines = int.Parse(Console.ReadLine());
        var enginesList = new List<Engine>(numofEngines);
        for (int i = 0; i < numofEngines; i++)
        {
            var splittedInput = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            var model = splittedInput[0];
            var power = int.Parse(splittedInput[1]);
            var engine = new Engine(model, power);
            enginesList.Add(engine);
            if (splittedInput.Length > 2)
            {
                int displacement;
                bool isDigit = int.TryParse(splittedInput[2], out displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = splittedInput[2];
                }
                if (splittedInput.Length > 3)
                {
                    if (isDigit)
                    {
                        engine.Efficiency = splittedInput[3];
                    }
                    else
                    {
                        engine.Displacement = int.Parse(splittedInput[3]);
                    }
                }
            }
            
            
        }
        return enginesList;
    }
}

