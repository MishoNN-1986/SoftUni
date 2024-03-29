﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;

        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
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

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public int? Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }

        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }

        public override string ToString()
        {
            string displacementStr = this.Displacement.HasValue ? //за int, проверяваме има ли стойност
                this.Displacement.ToString() : "n/a";
            string efficiencyStr = String.IsNullOrEmpty(this.Efficiency) ? // за string, проверяваме има стойност
                "n/a" : this.Efficiency;
            return $"  {this.Model}:{Environment.NewLine}   Power: {this.Power}{Environment.NewLine}" +
                $"   Displacement: {displacementStr}{Environment.NewLine}   Efficiency: {efficiencyStr}";
        }
    }
}
