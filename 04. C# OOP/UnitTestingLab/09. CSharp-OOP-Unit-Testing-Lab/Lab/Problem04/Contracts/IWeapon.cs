using System;
using System.Collections.Generic;
using System.Text;

namespace Problem04.Contracts
{
    public interface IWeapon
    {
        void Attack(ITarget target);
    }
}
