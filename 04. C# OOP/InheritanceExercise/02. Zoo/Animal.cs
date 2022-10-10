using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Zoo
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {this.Name}");
            return stringBuilder.ToString().TrimEnd()
;
        }
    }
}
