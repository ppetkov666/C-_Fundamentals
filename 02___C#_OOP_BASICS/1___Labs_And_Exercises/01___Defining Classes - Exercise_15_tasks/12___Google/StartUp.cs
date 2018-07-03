using System;
using System.Collections.Generic;
using System.Linq;
class StartUp
{
    public static void Main()
    {
        var fullInfo = CollectData();
        PrintPerson(fullInfo);
    }

    private static void PrintPerson(Queue<Person> fullInfo)
    {
        var personToPrint = Console.ReadLine();
        var person = fullInfo
            .FirstOrDefault(p => p.Name == personToPrint);

        if (person != null)
        {
            Console.Write(person.ToString());
        }
    }

    private static Queue<Person> CollectData()
    {
        var fullInfo = new Queue<Person>();
        var inputInfo = Console.ReadLine().Split();

        while (inputInfo[0] != "End")
        {
            var personName = inputInfo[0];
            var currentPerson = fullInfo.FirstOrDefault(p => p.Name == personName);

            if (currentPerson == null)
            {
                var person = new Person(personName);
                currentPerson = person;
                fullInfo.Enqueue(person);
            }

            OrderData(currentPerson, inputInfo);

            inputInfo = Console.ReadLine().Split();
        }
        return fullInfo;
    }

    private static void OrderData(Person currentPerson, string[] data)
    {
        switch (data[1])
        {
            case "company":
                var companyName = data[2];
                var salary = decimal.Parse(data[4]);
                var department = data[3];
                var company = new Company(companyName, salary, department);
                currentPerson.AssignACompany(company);
                break;
            case "pokemon":
                var pokemonName = data[2];
                var type = data[3];
                var pokemon = new Pokemon(pokemonName, type);
                currentPerson.AddInCollection(pokemon);
                break;
            case "parents":
                var parentName = data[2];
                var parentBirthDay = data[3];
                var parent = new Parent(parentName, parentBirthDay);
                currentPerson.AddInCollection(parent);
                break;
            case "children":
                var childName = data[2];
                var childBirthDay = data[3];
                var child = new Child(childName, childBirthDay);
                currentPerson.AddInCollection(child);
                break;
            case "car":
                var model = data[2];
                var speed = int.Parse(data[3]);
                var car = new Car(model, speed);
                currentPerson.AssignACar(car);
                break;
            default:
                break;
        }
    }

}

