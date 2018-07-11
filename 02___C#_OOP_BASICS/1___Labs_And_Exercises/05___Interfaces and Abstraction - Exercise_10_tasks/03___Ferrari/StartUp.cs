using System;
public class StartUp
{
    public const string CarModel = "488-Spider";
    static void Main()
    {
        
        var driver = Console.ReadLine();
        var ferrari = new Ferrari(CarModel, driver);
        Console.WriteLine(ferrari.ToString());
        
    }
}

