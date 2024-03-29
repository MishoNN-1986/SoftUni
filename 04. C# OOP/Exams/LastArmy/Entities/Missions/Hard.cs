﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Missions
{
    public class Hard : Mission
    {
        private const string name = "Disposal of terrorists";
        private const double enduranceRequired = 80;
        private const double wearLevelDecrement = 70;
        public override string Name => name;

        public override double EnduranceRequired => enduranceRequired;

        public override double WearLevelDecrement => wearLevelDecrement;

        public Hard(double scoreToComplete) : base(scoreToComplete)
        { }
    }
}
