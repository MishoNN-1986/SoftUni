using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Entities.Missions
{
    public abstract class Mission : IMission
    {
        public abstract string Name { get; }

        public abstract double EnduranceRequired { get; }

        public double ScoreToComplete { get; }

        public abstract double WearLevelDecrement { get; }

        protected Mission(double scoreToComplete)
        {
            ScoreToComplete = scoreToComplete;
        }
    }
}
