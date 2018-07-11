using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        List<Member> mixedCitizens = GetmixedCitizens();
        GetAllWithFakeIDs(mixedCitizens);
    }

    private static void GetAllWithFakeIDs(List<Member> mixedCitizens)
    {
        var idEnding = Console.ReadLine();

        mixedCitizens
            .Where(m => m.HasInvalidIdEnding(idEnding))
            .ToList()
            .ForEach(m => Console.WriteLine(m.Id));
    }

    private static List<Member> GetmixedCitizens()
    {
        var mixedCitizens = new List<Member>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            var splittArgs = ParseInput(input);
            switch (splittArgs.Length)
            {
                case 2:
                    string model = splittArgs[0];
                    string id = splittArgs[1];
                    mixedCitizens.Add(new Robot(id, model));
                    break;
                case 3:
                    string name = splittArgs[0];
                    int age = int.Parse(splittArgs[1]);
                    id = splittArgs[2];
                    mixedCitizens.Add(new Citizen(id, name, age));
                    break;
            }
        }

        return mixedCitizens;
    }

    private static string[] ParseInput(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}

