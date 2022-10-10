using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Ammunitions
{
    public class AutomaticMachine : Ammunition
    {
        private const double weight = 6.3;
        public override double Weight => weight;
    }
}
