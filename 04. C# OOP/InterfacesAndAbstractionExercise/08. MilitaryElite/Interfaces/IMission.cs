using System;
using System.Collections.Generic;
using System.Text;

namespace _08._MilitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        string State { get; }

        void CompleteMission();
    }
}
