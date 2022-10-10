using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Command
{
    public interface ITarget
    {
        void ReceiveDamage(int damage);

        bool IsDead { get; }

    }
}
