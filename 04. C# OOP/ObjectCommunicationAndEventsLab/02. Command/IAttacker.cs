using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Command
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}
