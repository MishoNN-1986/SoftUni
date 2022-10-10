using _09._InfernoInfinityRefactoringBonus.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Models.Wepons
{
    public class Knife : Weapon
    {
        public Knife(WeaponRarity rarity, string name)
            : base(rarity, name, 3, 4, 2)
        {
        }
    }
}
