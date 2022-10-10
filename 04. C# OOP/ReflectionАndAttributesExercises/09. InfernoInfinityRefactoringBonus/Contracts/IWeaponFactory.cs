using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Contracts
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string weaponRarity, string weaponType, string name);
    }
}
