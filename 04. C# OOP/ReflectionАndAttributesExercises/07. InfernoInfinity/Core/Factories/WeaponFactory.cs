﻿using _07._InfernoInfinity.Contracts;
using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Core.Factories
{
    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(string weaponRarity, string weaponType, string name)
        {
            WeaponRarity rarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), weaponRarity);

            Type classType = Type.GetType(weaponType);

            IWeapon instance = (IWeapon)Activator.CreateInstance(classType, new object[] { rarity, name });

            return instance;
        }
    }
}
