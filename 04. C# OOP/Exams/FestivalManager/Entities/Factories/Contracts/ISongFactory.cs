using FestivalManager.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Factories.Contracts
{
    public interface ISongFactory
    {
        ISong CreateSong(string name, TimeSpan duration);
    }
}
