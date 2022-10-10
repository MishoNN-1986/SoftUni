using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LastArmy.Factory
{
    public class MissionFactory : IMissionFactory
    {
        public IMission CreateMission(string difficultyLevel, double neededPoints)
        {
            var type = Assembly.GetCallingAssembly()
                .GetTypes().Single(t => t.Name == difficultyLevel);
            return (IMission)Activator.CreateInstance(type,
                neededPoints);
        }
    }
}
