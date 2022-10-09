using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private readonly List<Rabbit> data;
        private string name;
        private int capacity;

        private Cage()
        {
            this.data = new List<Rabbit>();
        }

        public Cage(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
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

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        } //без set

        public void Add(Rabbit rabit)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(rabit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabit = this.data
                .FirstOrDefault(r => r.Name == name);
            if (rabit != null)
            {
                this.data.Remove(rabit);
                return true;
            }
            return false;
            //foreach (var item in data)
            //{
            //    if (item.Name == name)
            //    {
            //        this.data.Remove(item);
            //        return true;
            //    }
            //}
            //return false;
        }

        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(r => r.Species == species);

        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data
                .FirstOrDefault(r => r.Name == name);
            if (rabbit != null)
            {
                rabbit.Availible = false;
            }
            return rabbit; // връща null или rabbit

        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = this.data
                .Where(r => r.Species == species).ToArray(); //where връща много(колекция)
            foreach (var rabbit in rabbits)
            {
                rabbit.Availible = false;
            }
            return rabbits;
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Rabbits available at {this.Name}:")
                .AppendLine(string.Join($"{Environment.NewLine}", this.data.Where(r => r.Availible)));
            return output.ToString().TrimEnd();
        }
    }
}
