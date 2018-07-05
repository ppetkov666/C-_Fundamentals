
public class Doctor
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public string FullName { get; set; }

    public Doctor(string firstname, string lastname)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.FullName = firstname + " " + lastname;
    }

}

