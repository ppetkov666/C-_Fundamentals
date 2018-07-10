using System;
using System.Text;
public class Tesla : Audi,IElectricCar
{
    public Tesla(string model, string color, int battery)
        : base(model,color)
    {
        this.Battery = battery;
    }

    public int Battery { get; private set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{base.Color} {this.GetType().Name} " +
            $"{base.Model} with {this.Battery} Batteries")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());

        return sb.ToString().Trim();
    }
}

