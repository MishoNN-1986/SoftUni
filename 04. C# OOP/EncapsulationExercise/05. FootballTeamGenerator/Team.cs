using _05._FootballTeamGenerator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._FootballTeamGenerator
{
    public class Team
    {
        private string name;
        List<Player> players;

        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(GlobalExceptions.EmptyNameExceptionMessage));
                }
                this.name = value;
            }
        }

        public void AddPlayer(string teamName, Player player)
        {
            if (this.name != teamName)
            {
                throw new ArgumentException(string.Format(GlobalExceptions.NonExistentTeamExceptionMessage, teamName));
            }
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException(string.Format(GlobalExceptions.MissingPlayerExceptionMessage, playerName, this.Name));
            }
            this.players.Remove(this.players.First(p => p.Name == playerName));
        }

        public int TeamStat(string teamName)
        {
            if (this.name != teamName)
            {
                throw new ArgumentException(string.Format(GlobalExceptions.NonExistentTeamExceptionMessage, teamName));
            }
            if (this.players.Count == 0)
            {
                return 0;
            }
            return (int)this.players.Average(p => p.CalculateAverageStat());
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TeamStat(this.Name)}";
        }

    }
}
