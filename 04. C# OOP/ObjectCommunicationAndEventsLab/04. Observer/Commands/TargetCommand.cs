using _04._Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Commands
{
    class TargetCommand : ICommand
    {
        private IAttacker attacker;
        private ITarget target;

        public TargetCommand(IAttacker attacker, ITarget target)
        {
            this.attacker = attacker;
            this.target = target;
        }

        public void Execute()
        {
            this.attacker.SetTarget(target);
        }
    }
}
