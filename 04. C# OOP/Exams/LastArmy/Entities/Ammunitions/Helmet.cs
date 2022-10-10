using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Ammunitions
{
    public class Helmet : Ammunition
    {
        private const double weight = 2.3;
        public override double Weight => weight;
    }
}
