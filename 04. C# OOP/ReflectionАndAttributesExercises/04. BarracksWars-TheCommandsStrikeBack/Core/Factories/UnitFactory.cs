using _04._BarracksWars_TheCommandsStrikeBack.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BarracksWars_TheCommandsStrikeBack.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            Type classType = Type.GetType("_04._BarracksWars_TheCommandsStrikeBack.Models_Units." + unitType);
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
