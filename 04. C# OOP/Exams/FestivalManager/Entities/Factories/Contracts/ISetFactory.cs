using FestivalManager.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Factories.Contracts
{
    public interface ISetFactory
    {
        ISet CreateSet(string name, string type);
    }
}
