using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface ISoldierFactory
    {
        ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance);
    }
}
