using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BarracksWars_TheCommandsStrikeBack.Contracts
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);
        string Statistics { get; }
        void RemoveUnit(string unitType);
    }
}
