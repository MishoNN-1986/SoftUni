using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Models_Units
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
