using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    public class FightCommand : Command
    {
        public FightCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}
