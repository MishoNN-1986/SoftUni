using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Contracts
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}
