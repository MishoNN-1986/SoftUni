﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Instruments
{
    public class Drums : Instrument
    {
        private const int RepairAm = 20;

        public Drums()
            : base(RepairAm)
        {
        }
    }
}
