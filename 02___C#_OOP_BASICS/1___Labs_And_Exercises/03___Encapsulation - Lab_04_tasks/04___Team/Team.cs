using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    public Team(string name)
    {
        
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
        this.Name = name;
    }
    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return this.firstTeam.AsReadOnly(); }
        
    }
    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return this.reserveTeam.AsReadOnly(); }
    }
    public string Name
    {
        get { return this.name; }
        set { name = value; }

    }

    public void AddPlayer(Person person)
    {
       
        if (person.Age < 40 )
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }
}

