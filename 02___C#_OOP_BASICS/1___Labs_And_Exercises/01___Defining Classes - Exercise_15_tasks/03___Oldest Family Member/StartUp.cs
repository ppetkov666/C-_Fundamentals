using System;
public class StartUp
{
    static void Main()
    {
        var countOfPeople = int.Parse(Console.ReadLine());
        Family allfamilymembers = new Family();
        for (int i = 0; i < countOfPeople; i++)
        {
            var personInput = Console.ReadLine().Split();
            var personName = personInput[0];
            var personAge = int.Parse(personInput[1]);
            Person person = new Person(personName, personAge);
            allfamilymembers.AddMember(person);    
        }

        Person oldestperson = allfamilymembers.GetOldestMember();
        Console.WriteLine($"{oldestperson.Name} {oldestperson.Age}");
        
    }
}

