using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IArmy
    {
        IReadOnlyList<ISoldier> Soldiers { get; }

        void AddSoldier(ISoldier soldier);

        void RegenerateTeam(string soldierType);
    }
}
