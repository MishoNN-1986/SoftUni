﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Models_Units
{
    public class Swordsman : Unit
    {
        private const int DefaultHealth = 40;
        private const int DefaultDamage = 13;

        public Swordsman()
            : base(DefaultHealth, DefaultDamage)
        {

        }
    }
}
