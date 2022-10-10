using _09._InfernoInfinityRefactoringBonus.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Models.Wepons
{
    public class Axe : Weapon
    {
        public Axe(WeaponRarity rarity, string name)
            : base(rarity, name, 5, 10, 4)
        {
        }
    }
}
