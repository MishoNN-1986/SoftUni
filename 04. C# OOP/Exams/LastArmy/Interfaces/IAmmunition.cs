using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IAmmunition
    {
        string Name { get; }

        double Weight { get; }

        double WearLevel { get; }

        void DecreaseWearLevel(double wearAmount);
    }
}
