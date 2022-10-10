using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Missions
{
    public class Easy : Mission
    {
        private const string name = "Suppression of civil rebellion";
        private const double enduranceRequired = 20;
        private const double wearLevelDecrement = 30;
        public override string Name => name;

        public override double EnduranceRequired => enduranceRequired;

        public override double WearLevelDecrement => wearLevelDecrement;

        public Easy(double scoreToComplete) : base(scoreToComplete)
        { }
    }
}
