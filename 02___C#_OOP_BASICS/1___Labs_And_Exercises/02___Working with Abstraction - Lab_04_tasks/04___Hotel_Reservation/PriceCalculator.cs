using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
class PriceCalculator
{
    private decimal pricePerNight;
    private int nights;
    private Seasons season;
    private Discounts discount;
    public PriceCalculator(string command)
    {

        var splittedCommand = command.Split();
         pricePerNight = decimal.Parse(splittedCommand[0]);
         nights = int.Parse(splittedCommand[1]);
         season = Enum.Parse<Seasons>(splittedCommand[2]);
        discount = Discounts.None;
        if (splittedCommand.Length > 3)
        {
            discount = Enum.Parse<Discounts>(splittedCommand[3]);
        }
    }
    public  string CalculatePrice()
    {
        // OPTIONAL CODE
        var color = GetColor(season);
        Console.WriteLine(color);
        // ENDS HERE

        var tempTotal = pricePerNight * nights * (int)season;
        var discountPercentage = ((decimal)100 - (int)discount) / 100;
        var totalprice = tempTotal * discountPercentage;
        return totalprice.ToString("f2");
    }
    // this is additional code just for example how powerfull are ENUMS !!!
    public  ConsoleColor GetColor(Seasons season)
    {
        switch (season)
        {
            case Seasons.Autumn:
                return ConsoleColor.Yellow;              
            case Seasons.Spring:
                return ConsoleColor.Green;
            case Seasons.Winter:
                return ConsoleColor.White;
            case Seasons.Summer:
                return ConsoleColor.Red;
            default:
                throw new InvalidEnumArgumentException();        
        }       
    }
}

