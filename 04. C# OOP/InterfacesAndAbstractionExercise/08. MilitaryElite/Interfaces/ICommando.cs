using System;
using System.Collections.Generic;
using System.Text;

namespace _08._MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
