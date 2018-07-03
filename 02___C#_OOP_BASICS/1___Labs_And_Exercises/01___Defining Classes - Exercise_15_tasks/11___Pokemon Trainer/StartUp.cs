using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        var trainers = GetTrainers();
        PlayWithElements(trainers);
        PrintTrainers(trainers);
    }

    private static void PrintTrainers(List<Trainer> trainers)
    {
        Console.WriteLine(string.Join(Environment.NewLine, trainers
            .OrderByDescending(t => t.Badges)
            .Select(t => $"{t.Name} {t.Badges} {t.Pokemons.Count}")));
    }
    private static void PlayWithElements(List<Trainer> trainers)
    {
        var element = Console.ReadLine().Trim();

        while (element != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons
                    .Where(p => p.Element == element)
                    .FirstOrDefault() == null)
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.ReduceHealth();
                    }

                    trainer.ClearDeadPokemons();
                }
                else
                {
                    trainer.AddABadge();
                }
            }
            element = Console.ReadLine().Trim();
        }
    }
    private static List<Trainer> GetTrainers()
    {
        var trainers = new List<Trainer>();
        var playerData = Console.ReadLine().Split();

        while (playerData[0] != "Tournament")
        {
            var trainerName = playerData[0];
            var pokemonName = playerData[1];
            var element = playerData[2];
            var health = int.Parse(playerData[3]);
            var currentPokemon = new Pokemon(pokemonName, element, health);
            var currentTrainer = trainers
                .Where(t => t.Name == trainerName)
                .FirstOrDefault();

            if (currentTrainer == null)
            {
                currentTrainer = new Trainer(trainerName);
                currentTrainer.Pokemons.Add(currentPokemon);
                trainers.Add(currentTrainer);
            }
            else
            {
                currentTrainer.Pokemons.Add(currentPokemon);
            }

            playerData = Console.ReadLine().Split();
        }

        return trainers;
    }
}

