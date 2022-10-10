using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Contracts
{
    public interface ITarget
    {
        void ReceiveDamage(int damage);

        bool IsDead { get; }
    }
}
