using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Models.Wepons
{
    public class Sword : Weapon
    {
        public Sword(WeaponRarity rarity, string name)
            : base(rarity, name, 4, 6, 3)
        {
        }
    }
}
