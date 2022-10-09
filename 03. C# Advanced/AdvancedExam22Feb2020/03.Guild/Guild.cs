using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private readonly List<Player> players;

        private Guild()
        {
            this.players = new List<Player>();
        }

        public Guild(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (this.players.Count < Capacity)
            {
                this.players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = players.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                players.Remove(player);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = this.players
                .FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = this.players
                .FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string itemClass)
        {
            Player[] players = this.players.Where(p => p.Class==itemClass).ToArray();
            this.players.RemoveAll(p => p.Class == itemClass);
            return players;
        }

        public int Count
        {
            get
            {
                return this.players.Count;
            }
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in this.players)
            {
                output.AppendLine(player.ToString());
            }
            return output.ToString().TrimEnd();
        }
    }
}
