using _03._Mediator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Commands
{
    public class AttackCommand : ICommand
    {
        IAttacker attacker;

        public AttackCommand(IAttacker attacker)
        {
            this.attacker = attacker;
        }

        public void Execute()
        {
            this.attacker.Attack();
        }
    }
}
