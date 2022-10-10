using _04._BarracksWars_TheCommandsStrikeBack.Contracts;
using _04._BarracksWars_TheCommandsStrikeBack.Core;
using _04._BarracksWars_TheCommandsStrikeBack.Core.Factories;
using _04._BarracksWars_TheCommandsStrikeBack.Data;
using System;

namespace _04._BarracksWars_TheCommandsStrikeBack
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
