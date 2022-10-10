using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FestivalManager.Entities.Factories
{
    public class SetFactory : ISetFactory
    {
        public ISet CreateSet(string name, string type)
        {
            Type typeClass = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);
            ISet instance = (ISet)Activator.CreateInstance(typeClass, name);

            return instance;
        }
    }
}
