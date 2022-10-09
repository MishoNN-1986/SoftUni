using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;
        
        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();  //!!!!!
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }
            set
            {
                this.numberOfBadges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void GetBadge()
        {
            this.NumberOfBadges++;
        }

        public void ReducePokemonsHealth()
        {
            this.Pokemons.ForEach(p => p.ReduceHealth());
        }

        public void RemoveDead()
        {
            this.Pokemons = this.Pokemons
                .Where(p => p.Health > 0)
                .ToList();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}";
        }
    }
}
