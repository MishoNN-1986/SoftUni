using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}
