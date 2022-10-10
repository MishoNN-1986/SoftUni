using _03._Mediator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Commands
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
