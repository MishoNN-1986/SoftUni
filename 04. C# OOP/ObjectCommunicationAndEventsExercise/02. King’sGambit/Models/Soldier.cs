using System;
using System.Collections.Generic;
using System.Text;

namespace _02._King_sGambit.Models
{
    public abstract class Soldier
    {
        public Soldier(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void KingUnderAttack();
    }
}
