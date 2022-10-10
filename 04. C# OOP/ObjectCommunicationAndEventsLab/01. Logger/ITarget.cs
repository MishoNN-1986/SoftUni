using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public interface ITarget
    {
        void ReceiveDamage(int damage);

        bool IsDead { get; }

    }
}
