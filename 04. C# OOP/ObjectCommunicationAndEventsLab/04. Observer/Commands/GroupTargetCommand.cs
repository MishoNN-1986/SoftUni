using _04._Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Commands
{
    public class GroupTargetCommand : ICommand
    {
        private IAttackGroup attackGroup;
        private ITarget target;

        public GroupTargetCommand(IAttackGroup attackGroup, ITarget target)
        {
            this.attackGroup = attackGroup;
            this.target = target;
        }

        public void Execute()
        {
            this.attackGroup.GroupTarget(target);
        }
    }
}
