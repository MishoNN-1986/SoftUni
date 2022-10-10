using _05._BarracksWars_ReturnOfTheDependencies.Contracts;
using _05._BarracksWars_ReturnOfTheDependencies.Core;
using _05._BarracksWars_ReturnOfTheDependencies.Core.Factories;
using _05._BarracksWars_ReturnOfTheDependencies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies
{
    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
