using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Ammunitions
{
    public class Knife : Ammunition
    {
        private const double weight = 0.4;
        public override double Weight => weight;
    }
}
