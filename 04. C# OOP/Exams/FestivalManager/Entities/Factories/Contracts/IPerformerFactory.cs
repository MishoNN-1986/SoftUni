using FestivalManager.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Factories.Contracts
{
    public interface IPerformerFactory
    {
        IPerformer CreatePerformer(string name, int age);
    }
}
