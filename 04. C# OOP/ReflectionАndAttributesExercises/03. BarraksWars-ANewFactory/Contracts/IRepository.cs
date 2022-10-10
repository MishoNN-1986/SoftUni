using System;
using System.Collections.Generic;
using System.Text;

namespace _03._BarraksWars_ANewFactory.Contracts
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);
        string Statistics { get; }
        void RemoveUnit(string unitType);
    }
}
