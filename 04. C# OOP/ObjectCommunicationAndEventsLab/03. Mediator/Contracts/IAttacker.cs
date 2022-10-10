using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Contracts
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}
