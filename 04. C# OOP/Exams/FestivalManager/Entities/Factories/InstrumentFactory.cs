using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FestivalManager.Entities.Factories
{
    public class InstrumentFactory : IInstrumentFactory
    {
        public IInstrument CreateInstrument(string type)
        {
            Type typeClass = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);
            IInstrument instance = (IInstrument)Activator.CreateInstance(typeClass);

            return instance;
        }
    }
}
