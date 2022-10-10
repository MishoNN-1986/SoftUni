using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Ammunitions
{
    public class Gun : Ammunition
    {
        private const double weight = 1.4;
        public override double Weight => weight;
    }
}
