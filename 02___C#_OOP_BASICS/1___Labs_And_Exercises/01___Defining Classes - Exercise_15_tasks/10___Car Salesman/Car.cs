using System;

class Car
{
    private string model;
    private Engine engine;
    private double? weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
    }
    public override string ToString()
    {
        var result = $"{this.model}:";
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.engine.ToString());
        result = string.Concat(result, this.weight == null ? "  Weight: n/a" : $"  Weight: {this.weight}");
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.color == null ? "  Color: n/a" : $"  Color: {this.color}");
        result = string.Concat(result, Environment.NewLine);

        return result;
    }
    public string Model
    {
        get { return this.model; }
        set { model = value; }
    }
    public Engine Engine
    {
        get { return this.engine; }
        set { engine = value; }
    }
    public double? Weight
    {
        get { return this.weight; }
        set { weight = value; }
    }
    public string Color
    {
        get { return this.color; }
        set { color = value; }
    }


}

