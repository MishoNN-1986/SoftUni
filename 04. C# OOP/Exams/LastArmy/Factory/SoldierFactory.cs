﻿using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LastArmy.Factory
{
    public class SoldierFactory : ISoldierFactory
    {
        public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == soldierTypeName);
            return (ISoldier)Activator.CreateInstance(type,
                name, age, experience, endurance);
        }
    }
}
