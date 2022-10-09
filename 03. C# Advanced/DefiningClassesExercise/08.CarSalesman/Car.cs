using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;    //за да може да се сетне на null;  
        private string color; // string е референтен тип и може да е null, за това не се слага ?

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public int? Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            string weightStr = this.Weight.HasValue ?
                this.Weight.ToString() : "n/a";
            string colorStr = String.IsNullOrEmpty(this.Color) ?
                "n/a" : this.Color;
            return $"{Environment.NewLine}{this.Model}:{Environment.NewLine}{this.Engine}{Environment.NewLine} Weight: {weightStr}{Environment.NewLine}" +
                $" Color: {colorStr}";
            // може и с .AppendLine.AppendLine....
        }
    }
}
