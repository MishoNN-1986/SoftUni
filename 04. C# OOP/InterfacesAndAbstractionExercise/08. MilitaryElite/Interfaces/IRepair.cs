using System;
using System.Collections.Generic;
using System.Text;

namespace _08._MilitaryElite.Interfaces
{
    public interface IRepair
    {
        string Part { get; }

        int Hours { get; }
    }
}
