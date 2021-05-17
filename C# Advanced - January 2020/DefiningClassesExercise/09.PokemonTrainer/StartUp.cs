using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] informationAboutPokemonAndTrainer = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string trainerName = informationAboutPokemonAndTrainer[0];
                string pokemonName = informationAboutPokemonAndTrainer[1];
                string pokemonElement = informationAboutPokemonAndTrainer[2];
                int pokemonHealth = int.Parse(informationAboutPokemonAndTrainer[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = new Trainer(trainerName);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    trainers.Add(trainer);
                }
                trainer = trainers.First(t => t.Name == trainerName);
                trainer.AddPokemon(pokemon);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.GetBadge();
                    }
                    else
                    {
                        trainer.ReducePokemonsHealth();
                        trainer.RemoveDead();
                    }
                }
                command = Console.ReadLine();
            }
            trainers.OrderByDescending(b => b.NumberOfBadges)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
