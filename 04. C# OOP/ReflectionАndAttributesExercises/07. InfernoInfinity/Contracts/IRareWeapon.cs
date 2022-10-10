using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Contracts
{
    public interface IRareWeapon
    {
        WeaponRarity Rarity { get; }
    }
}
