using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Contracts
{
    public interface IAttackGroup
    {
        void AddMember(IAttacker attacker);

        void GroupTarget(ITarget target);

        void GroupAttack();
    }
}
