using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {

        List<IBirthdate> membersWithBIrthdates = Getmembers();
        GetMembersByBirthdate(membersWithBIrthdates);
    }
    private static void GetMembersByBirthdate(List<IBirthdate> members)
    {
        var year = Console.ReadLine();

        members
            .Where(m => m.BirthDate.EndsWith(year))
            .ToList()
            .ForEach(m => Console.WriteLine(m.BirthDate));
    }
    private static List<IBirthdate> Getmembers()
    {
        var members = new List<IBirthdate>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "End") break;

            var inputArgs = ParseInput(input);

            var memberType = inputArgs[0].ToLower();
            inputArgs = inputArgs.Skip(1).ToArray();

            switch (memberType)
            {
                case "citizen":
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];
                    string birthdate = inputArgs[3];
                    members.Add(new Citizen(id, name, age, birthdate));
                    break;
                case "pet":
                    name = inputArgs[0];
                    birthdate = inputArgs[1];
                    members.Add(new Pet(name, birthdate));
                    break;
            }
        }
        return members;
    }
    private static string[] ParseInput(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}

