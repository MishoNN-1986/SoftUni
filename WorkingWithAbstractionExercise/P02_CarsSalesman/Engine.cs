using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private string model;
        private double? power;
        private double? displacement;
        private string efficiency;

        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, double power, double displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, double power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, double power, double displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }
        public double Power { get; set; }
        public double? Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacementStr = this.Displacement.HasValue ? //за int, проверяваме има ли стойност
                this.Displacement.ToString() : "n/a";
            string efficiencyStr = String.IsNullOrEmpty(this.Efficiency) ? // за string, проверяваме има стойност
                "n/a" : this.Efficiency;
            StringBuilder engineDetails = new StringBuilder();
            engineDetails.AppendLine($"  {this.Model}:");
            engineDetails.AppendLine($"    Power: {this.Power}");
            engineDetails.AppendLine($"    Displacement: {displacementStr}");
            engineDetails.AppendLine($"    Efficiency: {efficiencyStr}");
            return engineDetails
                .ToString()
                .TrimEnd();
        }

    }
}
