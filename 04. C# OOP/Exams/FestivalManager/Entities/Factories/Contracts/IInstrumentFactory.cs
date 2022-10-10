using FestivalManager.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Factories.Contracts
{
    public interface IInstrumentFactory
    {
        IInstrument CreateInstrument(string type);
    }
}
