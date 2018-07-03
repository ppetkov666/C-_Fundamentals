
class Cat
{
    private string name;
    private string breed;
    private double specifics;

    public Cat(string name, string breed, double specifics)
    {
        this.name = name;
        this.breed = breed;
        this.specifics = specifics;
    }
    public string Name
    {
        get { return this.name; }
    }
    public override string ToString()
    {
        if (this.breed == "Cymric")
        {
            var output = $"{this.breed} {this.name} {this.specifics:f2}";
            return output;
        }
        else
        {
            var output = $"{this.breed} {this.name} {(int)this.specifics}";
            return output;
        }
    }
}

