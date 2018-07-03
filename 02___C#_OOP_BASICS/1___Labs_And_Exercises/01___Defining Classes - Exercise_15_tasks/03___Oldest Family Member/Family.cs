using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Family
{
    List<Person> familymember;
    public Family()
    {
        familymember = new List<Person>();
    }
    public void AddMember(Person member)
    {
        familymember.Add(member);
    }
    public Person GetOldestMember()
    {
        Person oldestmember = familymember
            .OrderByDescending(p => p.Age)
            .FirstOrDefault();
        return oldestmember;
    }

   
}

