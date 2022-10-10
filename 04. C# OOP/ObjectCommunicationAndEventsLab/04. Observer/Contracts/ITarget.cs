using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Contracts
{
    public interface ITarget
    {
        void ReceiveDamage(int damage);

        bool IsDead { get; }

    }
}
