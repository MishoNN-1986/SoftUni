using _09._InfernoInfinityRefactoringBonus.Common;
using _09._InfernoInfinityRefactoringBonus.Contracts;
using _09._InfernoInfinityRefactoringBonus.Core;
using _09._InfernoInfinityRefactoringBonus.Core.Factories;
using _09._InfernoInfinityRefactoringBonus.Data;
using System;

namespace _09._InfernoInfinityRefactoringBonus
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var repository = new WeaponRepository();
            var interpreter = new CommandInterpreter();
            var weaponFactory = new WeaponFactory();
            var gemFactory = new GemFactory();
            var reader = new Reader();
            var writer = new Writer();

            IRunnable engine = new Engine(gemFactory, weaponFactory, interpreter, repository, reader, writer);

            engine.Run();
        }
    }
}
