﻿using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastArmy.Entities
{
    public class Army : IArmy
    {
        private List<ISoldier> soldiers;
        public IReadOnlyList<ISoldier> Soldiers => soldiers;

        public Army()
        {
            soldiers = new List<ISoldier>();
        }

        public void AddSoldier(ISoldier soldier)
        {
            soldiers.Add(soldier);
        }

        public void RegenerateTeam(string soldierType)
        {
            foreach (var soldier in soldiers.Where(s => s.GetType().Name == soldierType))
            {
                soldier.Regenerate();
            }
        }
    }
}
