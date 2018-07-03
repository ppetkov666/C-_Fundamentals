
class Pokemon
{
    private string name;
    private string element;
    private int health;

    public Pokemon(string name, string element, int health)
    {
        this.name = name;
        this.element = element;
        this.health = health;
    }

    public int Health => health;

    public string Element => element;

    public void ReduceHealth()
    {
        this.health -= 10;
    }
}

