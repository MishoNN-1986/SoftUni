using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Core.Commands
{
    public class EndCommand : Command
    {
        public EndCommand(string[] data)
            : base(data)
        {
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
