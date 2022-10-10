using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BarracksWars_TheCommandsStrikeBack.Models_Units
{
    public class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        public Horseman()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
