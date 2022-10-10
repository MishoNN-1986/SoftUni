using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Players_and_Monsters
{
    public class Hero
    {
        private string username;
        private int level;

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public string Username { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
