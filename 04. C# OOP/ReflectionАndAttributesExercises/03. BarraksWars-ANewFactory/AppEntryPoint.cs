using _03._BarraksWars_ANewFactory.Contracts;
using _03._BarraksWars_ANewFactory.Core;
using _03._BarraksWars_ANewFactory.Core.Factories;
using _03._BarraksWars_ANewFactory.Data;
using System;

namespace _03._BarraksWars_ANewFactory
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
