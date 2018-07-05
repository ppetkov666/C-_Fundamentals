using System.Text;

class Engine
{
    private string model;
    private int power;
    private int? displacement;
    private string efficiency;
    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
    }
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"  {this.model}:");
        output.AppendLine($"    Power: {this.power}");
        output.AppendLine(this.displacement == null ? 
            "    Displacement: n/a" : $"    Displacement: {this.displacement}");
        output.Append(this.efficiency == null ?
            "    Efficiency: n/a" : $"    Efficiency: {this.efficiency}");
        return output.ToString();
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
