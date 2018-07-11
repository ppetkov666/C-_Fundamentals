public class Pet : IBirthdate
{
    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.BirthDate = birthdate;
    }

    public string Name { get; }

    public string BirthDate { get; }
}