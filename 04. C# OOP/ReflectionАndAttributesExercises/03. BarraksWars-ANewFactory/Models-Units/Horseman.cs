﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._BarraksWars_ANewFactory.Models_Units
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
