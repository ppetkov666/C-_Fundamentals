using System;

class Engine
{
    private string model;
    private int power;
    private int? displacement;
    private string efficiency;

    public Engine(string model,int power)
    {
        this.model = model;
        this.power = power;
    }
    public override string ToString()
    {
        var result = $"  {this.model}:";
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, $"    Power: {this.power}");
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.displacement == null ? "    Displacement: n/a" : $"    Displacement: {this.displacement}");
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {this.efficiency}");
        result = string.Concat(result, Environment.NewLine);

        return result;
    }

    public string Model
    {
        get { return this.model; }
        set { model = value; }
    }
    public int Power
    {
        get { return this.power; }
        set { power = value; }
    }
    public int? Displacement
    {
        get { return this.displacement; }
        set { displacement = value; }
    }
    public string Efficiency
    {
        get { return this.efficiency; }
        set { efficiency = value; }
    }
}

