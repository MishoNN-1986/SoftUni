using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Instruments
{
    public class Guitar : Instrument
    {
        private const int RepairAm = 60;

        public Guitar()
            : base(RepairAm)
        {
        }
    }
}
