using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IMission
    {
        string Name { get; }

        double EnduranceRequired { get; }

        double ScoreToComplete { get; }

        double WearLevelDecrement { get; }
    }
}
