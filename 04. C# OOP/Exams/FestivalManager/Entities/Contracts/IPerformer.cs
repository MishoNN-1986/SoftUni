using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Contracts
{
    public interface IPerformer
    {
        string Name { get; }

        int Age { get; }

        IReadOnlyCollection<IInstrument> Instruments { get; }

        void AddInstrument(IInstrument instrument);
    }
}
