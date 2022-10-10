using System;
using System.Collections.Generic;
using System.Text;

namespace _10._TirePressureMonitoringSystem
{
    public interface ISensor
    {
        double PopNextPressurePsiValue();
    }
}
