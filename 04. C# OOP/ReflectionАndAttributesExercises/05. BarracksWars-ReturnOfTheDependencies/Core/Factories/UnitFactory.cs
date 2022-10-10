using _05._BarracksWars_ReturnOfTheDependencies.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            Type classType = Type.GetType("_05._BarracksWars_ReturnOfTheDependencies.Models_Units." + unitType);
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
