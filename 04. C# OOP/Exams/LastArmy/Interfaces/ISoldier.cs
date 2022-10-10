using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface ISoldier
    {
        string Name { get; }

        int Age { get; }

        double Experience { get; }

        double Endurance { get; }

        double OverallSkill { get; }

        IDictionary<string, IAmmunition> Weapons { get; }

        void Regenerate();

        bool ReadyForMission(IMission mission);

        void CompleteMission(IMission mission);
    }
}
