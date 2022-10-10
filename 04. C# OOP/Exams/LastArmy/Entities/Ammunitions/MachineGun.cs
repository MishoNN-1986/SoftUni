using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Ammunitions
{
    public class MachineGun : Ammunition
    {
        private const double weight = 10.6;
        public override double Weight => weight;
    }
}
