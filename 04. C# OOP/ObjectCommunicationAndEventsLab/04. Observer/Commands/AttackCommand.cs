using _04._Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Commands
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
