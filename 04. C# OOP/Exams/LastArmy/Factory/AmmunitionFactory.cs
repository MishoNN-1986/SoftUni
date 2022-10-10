using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LastArmy.Factory
{
    public class AmmunitionFactory : IAmmunitionFactory
    {
        public IAmmunition CreateAmmunition(string name)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == name);
            return (IAmmunition)Activator.CreateInstance(type);
        }
    }
}
