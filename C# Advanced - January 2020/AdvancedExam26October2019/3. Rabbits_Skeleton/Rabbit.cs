using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class Rabbit
    {
        //private string name;
        //private string species;
        //private bool availible;

        private Rabbit()
        {
            this.Availible = true;
        } //ако е по дефолулт се пише така и след това се наследява

        public Rabbit(string name, string species)
            : this()
        {
            this.Name = name;
            this.Species = species;
        }
        public string Name { get; set; }
        public string Species { get; set; }
        public bool Availible { get; set; }

        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}

        //public string Species
        //{
        //    get
        //    {
        //        return this.species;
        //    }
        //    set
        //    {
        //        this.species = value;
        //    }
        //}

        //public bool Availible
        //{
        //    get
        //    {
        //        return this.availible;
        //    }
        //    set
        //    {
        //        this.availible = value;
        //    }
        //}

        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}";
        }
    }
}
