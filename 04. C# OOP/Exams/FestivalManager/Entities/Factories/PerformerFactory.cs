using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FestivalManager.Entities.Factories
{
    public class PerformerFactory : IPerformerFactory
    {
        public IPerformer CreatePerformer(string name, int age)
        {
            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == "Performer");
            IPerformer instance = (IPerformer)Activator.CreateInstance(type, name, age);

            return instance;
        }
    }
}
