using _05._FootballTeamGenerator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
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

        private Stats Stats
        {
            set
            {
                this.stats = value;
            }
        }

        public int CalculateAverageStat()
        {
            return (int)Math
                .Round((this.stats.Dribble +
                this.stats.Endurance +
                this.stats.Passing +
                this.stats.Shooting +
                this.stats.Sprint) / 5.0);
        }
    }
}
