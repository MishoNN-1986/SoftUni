using _03._Mediator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Commands
{
    public class GroupAttackCommand : ICommand
    {
        private IAttackGroup attackGroup;

        public GroupAttackCommand(IAttackGroup attackGroup)
        {
            this.attackGroup = attackGroup;
        }

        public void Execute()
        {
            this.attackGroup.GroupAttack();
        }
    }
}
