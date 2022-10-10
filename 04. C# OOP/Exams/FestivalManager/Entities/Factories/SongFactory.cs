using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Factories
{
    public class SongFactory : ISongFactory
    {
        public ISong CreateSong(string name, TimeSpan duration)
        {
            var song = new Song(name, duration);
            return song;
        }
    }
}
