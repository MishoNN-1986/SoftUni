using System;
using System.Collections.Generic;
using System.Text;

namespace Problem04.Contracts
{
    public interface ITarget
    {
        int Health { get; }

        void TakeAttack(int attackPoints);

        int GiveExperience();

        bool IsDead();
    }
}
