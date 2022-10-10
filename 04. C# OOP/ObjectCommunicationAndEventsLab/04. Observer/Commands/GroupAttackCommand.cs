using _04._Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Commands
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
