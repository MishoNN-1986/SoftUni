using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Contracts
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string weaponRarity, string weaponType, string name);
    }
}
