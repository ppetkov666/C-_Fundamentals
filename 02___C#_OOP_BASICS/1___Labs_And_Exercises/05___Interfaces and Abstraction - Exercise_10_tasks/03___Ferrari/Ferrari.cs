﻿using System.Text;
public class Ferrari : ICar
{
    public Ferrari(string model, string driver)
    {
        this.Model = model;
        this.Driver = driver;
    }

    public string Model { get; }
    public string Driver { get; }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string UseGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{this.Model}/{this.UseBrakes()}" +
            $"/{this.UseGasPedal()}/{this.Driver}");
        return sb.ToString().Trim();
    }
}