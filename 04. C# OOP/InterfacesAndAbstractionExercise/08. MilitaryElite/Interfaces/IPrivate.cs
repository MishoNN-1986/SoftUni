using System;
using System.Collections.Generic;
using System.Text;

namespace _08._MilitaryElite.Interfaces
{
    public interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}
