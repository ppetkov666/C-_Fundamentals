public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            Validator.ValidateName(value);
            name = value;
        }
    }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            Validator.ValidateMoney(value);
            price = value;
        }
    }
    public override string ToString()
    {
        return this.Name;
    }
}

