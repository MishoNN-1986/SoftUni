using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IWareHouse
    {
        void EquipArmy(IArmy army);
        void AddAmmunition(string ammunition, int quantity);
        bool TryEquipSoldier(ISoldier soldier);
    }
}
