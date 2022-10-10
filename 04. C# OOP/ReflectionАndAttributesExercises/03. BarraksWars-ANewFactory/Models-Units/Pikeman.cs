﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._BarraksWars_ANewFactory.Models_Units
{
    public class Pikeman : Unit
    {
        private const int DefaultHealth = 30;
        private const int DefaultDamage = 15;

        public Pikeman()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
