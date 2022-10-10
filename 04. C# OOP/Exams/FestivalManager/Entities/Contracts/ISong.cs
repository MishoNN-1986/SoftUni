using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Contracts
{
    public interface ISong
    {
        string Name { get; }

        TimeSpan Duration { get; }
    }
}
