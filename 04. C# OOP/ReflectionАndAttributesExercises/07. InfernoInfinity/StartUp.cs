using _07._InfernoInfinity.Contracts;
using _07._InfernoInfinity.Core;
using _07._InfernoInfinity.Core.Factories;
using _07._InfernoInfinity.Data;
using System;

namespace _07._InfernoInfinity
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var repository = new WeaponRepository();
            var interpreter = new CommandInterpreter();
            var weaponFactory = new WeaponFactory();
            var gemFactory = new GemFactory();

            IRunnable engine = new Engine(gemFactory, weaponFactory, interpreter, repository);

            engine.Run();
        }
    }
}
