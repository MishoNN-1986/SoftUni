using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Contracts
{
    public interface IInstrument
    {
        double Wear { get; }

        void Repair();

        void WearDown();

        bool IsBroken { get; }
    }
}
