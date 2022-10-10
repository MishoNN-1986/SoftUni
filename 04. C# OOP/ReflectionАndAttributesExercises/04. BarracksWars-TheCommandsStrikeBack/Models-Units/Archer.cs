using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BarracksWars_TheCommandsStrikeBack.Models_Units
{
    public class Archer : Unit
    {
        private const int DefaultHealth = 25;
        private const int DefaultDamage = 7;

        public Archer()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
