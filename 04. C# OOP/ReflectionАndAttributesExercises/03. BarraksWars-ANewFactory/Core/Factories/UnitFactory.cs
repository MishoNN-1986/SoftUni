using _03._BarraksWars_ANewFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._BarraksWars_ANewFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            Type classType = Type.GetType("_03._BarraksWars_ANewFactory.Models_Units." + unitType);
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
