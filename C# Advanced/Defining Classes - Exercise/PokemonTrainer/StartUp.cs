using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main()
        {
            var trainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                var sep = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                var trainerName = sep[0];
                var pokemonName = sep[1];
                var element = sep[2];
                var health = int.Parse(sep[3]);
                
                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer != null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                }
                else
                {
                    var newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                    trainers.Add(newTrainer);
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (!trainers[i].Pokemons.Any(x => x.Element == command))
                    {
                        foreach (var pokemon in trainers[i].Pokemons)
                        {
                            pokemon.ReduceHealth();
                        }
                            trainers[i].Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                    else
                    {
                        trainers[i].IncreaceNumberOfBadges();
                    }
                }
                command = Console.ReadLine();
            }
            trainers.OrderByDescending(x => x.NumberOfBadges).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.NumberOfBadges} {x.Pokemons.Count}"));
        }
    }
}