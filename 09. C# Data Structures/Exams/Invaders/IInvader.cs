using System;
using System.Collections.Generic;
using System.Text;

namespace Invaders
{
    public interface IInvader : IComparable<IInvader>
    {
        int Damage { get; set; }

        int Distance { get; set; }
    }
}
