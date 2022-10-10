using System;
using System.Collections.Generic;
using System.Text;

namespace _02._King_sGambit.Models
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name)
            : base(name)
        {
        }

        public override void KingUnderAttack()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
