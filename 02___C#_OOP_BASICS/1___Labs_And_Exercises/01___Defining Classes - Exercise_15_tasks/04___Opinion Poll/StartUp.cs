using System;
using System.Collections.Generic;
using System.Linq;
class StartUp
{
    static void Main()
    {
        var countOfPeople = int.Parse(Console.ReadLine());
        var listOfPeople = new List<Person>();
        for (int i = 0; i < countOfPeople; i++)
        {
            var inputPerson = Console.ReadLine().Split();
            var name = inputPerson[0];
            var age = int.Parse(inputPerson[1]);
            Person person = new Person(name, age);
            listOfPeople.Add(person);

        }
        var sortedListToAge = listOfPeople
            .Where(p => p.Age > 30)
            .OrderBy(p => p.Name);
        foreach (var person in sortedListToAge)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

