using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        private Player()
        {
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public Player(string name, string itemClass)
            : this()
        {
            this.Name = name;
            this.Class = itemClass;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Player {this.Name}: {this.Class}");
            output.AppendLine($"Rank: {this.Rank}");
            output.AppendLine($"Description: {this.Description}");

            return output.ToString().TrimEnd();
        }
    }
}
