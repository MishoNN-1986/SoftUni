using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IMissionFactory
    {
        IMission CreateMission(string difficultyLevel, double neededPoints);
    }
}
