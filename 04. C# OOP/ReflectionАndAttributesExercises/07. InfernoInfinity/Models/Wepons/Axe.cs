using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Models.Wepons
{
    public class Axe : Weapon
    {
        public Axe(WeaponRarity rarity, string name)
            : base(rarity, name, 5, 10, 4)
        {
        }
    }
}
