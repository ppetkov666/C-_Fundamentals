using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {

        CreateTeams();
    }

    private static void CreateTeams()
    {
        var teams = new HashSet<Team>();

        var command = Console.ReadLine()
            .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        while (command[0] != "END")
        {
            try
            {
                switch (command[0])
                {
                    case "Team":
                        teams.Add(new Team(command[1]));
                        break;
                    case "Add":
                        AddPlayerAtTheTeam(teams, command);
                        break;
                    case "Remove":
                        RemovePlayerFromTeam(teams, command);
                        break;
                    case "Rating":
                        PrintRating(teams, command);
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            command = Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
    private static void PrintRating(HashSet<Team> teams, string[] command)
    {
        var team = teams.FirstOrDefault(t => t.Name == command[1]);

        if (team == null)
        {
            Console.WriteLine($"Team {command[1]} does not exist.");
            return;
        }

        Console.WriteLine($"{team.Name} - {Math.Round(team.GetRating())}");
    }

    private static void RemovePlayerFromTeam(HashSet<Team> teams, string[] command)
    {
        try
        {
            var team = teams.FirstOrDefault(t => t.Name == command[1]);
            team.RemovePlayer(command[2]);
        }
        catch (InvalidOperationException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (NullReferenceException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static void AddPlayerAtTheTeam(HashSet<Team> teams, string[] command)
    {
        var team = teams.FirstOrDefault(t => t.Name == command[1]);

        if (team == null)
        {
            Console.WriteLine($"Team {command[1]} does not exist.");
            return;
        }

        var player = new Player(command[2], double.Parse(command[3]),
            double.Parse(command[4]), double.Parse(command[5]),
            double.Parse(command[6]), double.Parse(command[7]));
        team.AddPlayer(player);
    }
}

