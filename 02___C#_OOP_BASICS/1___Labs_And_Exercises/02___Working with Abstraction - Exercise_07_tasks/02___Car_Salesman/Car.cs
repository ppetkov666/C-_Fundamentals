using System.Text;

class Car
{
    private string model;
    private Engine engine;
    private double? weight;
    private string color;
    public Car(string model,Engine engine)
    {
        this.model = model;
        this.engine = engine;
    }
    public override string ToString()
    {
        var finalOutput = new StringBuilder();
        finalOutput.AppendLine($"{this.model}:");
        finalOutput.AppendLine($"{engine}");
        finalOutput.AppendLine(weight == null ?
            "  Weight: n/a" : $"  Weight: {this.weight}");
        finalOutput.Append(color == null ? 
            "  Color: n/a" : $"  Color: {this.color}");
        return finalOutput.ToString();
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

