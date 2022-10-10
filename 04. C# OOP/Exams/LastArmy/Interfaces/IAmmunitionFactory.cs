using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IAmmunitionFactory
    {
        IAmmunition CreateAmmunition(string ammunitionName);
    }
}
