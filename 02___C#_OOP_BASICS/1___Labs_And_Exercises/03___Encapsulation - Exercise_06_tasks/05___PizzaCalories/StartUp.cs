using System;
class StartUp
{
    static void Main()
    {
        try
        {
            var pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = new Pizza(pizzaName);
            Dough dough = SetDough();
            pizza.SetDough(dough);
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                AddToping(pizza, command);
            }
            Console.WriteLine(pizza);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
        
    }

    private static Dough SetDough()
    {
        var doughInput = Console.ReadLine().Split();
        var flowerType = doughInput[1];
        var bakingTechnique = doughInput[2];
        var weight = double.Parse(doughInput[3]);
        Dough dough = new Dough(flowerType, bakingTechnique, weight);
        return dough;
    }

    private static void AddToping(Pizza pizza, string command)
    {
        var topingInput = command.Split();
        var topingType = topingInput[1];
        var topingWeight = double.Parse(topingInput[2]);
        var topping = new Topping(topingType, topingWeight);
        pizza.AddToping(topping);
    }
}

