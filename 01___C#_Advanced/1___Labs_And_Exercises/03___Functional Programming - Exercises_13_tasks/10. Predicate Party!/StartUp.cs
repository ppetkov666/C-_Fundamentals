namespace _10._Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var countOfPeopleComing = Console.ReadLine()
                  .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            Commands(countOfPeopleComing);
            PrintTheListOfPeople(countOfPeopleComing);
        }
        private static void PrintTheListOfPeople(List<string> countOfPeopleComing)
        {
            if (countOfPeopleComing.Any())
            {
                var names = string.Join(", ", countOfPeopleComing);
                Console.WriteLine($"{names} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static void Commands(List<string> countOfPeopleComing)
        {
            var command = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Party!")
            {
                if (command.Length < 3)
                {
                    command = Console.ReadLine()
                        .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                switch (command[1])
                {
                    case "StartsWith":
                        Names(command[0], countOfPeopleComing, p => p.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        Names(command[0], countOfPeopleComing, p => p.EndsWith(command[2]));
                        break;
                    case "Length":
                        Names(command[0], countOfPeopleComing, p => p.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
        }
        private static void Names(string command, List<string> countOfPeopleComing, Func<string, bool> condition)
        {
            for (int i = countOfPeopleComing.Count - 1; i >= 0; i--)
            {
                if (condition(countOfPeopleComing[i]))
                {
                    if (command == "Remove") countOfPeopleComing.RemoveAt(i);
                    else if (command == "Double") countOfPeopleComing.Add(countOfPeopleComing[i]);                     
                }
            }
        }
    }
}
