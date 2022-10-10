using FestivalManager.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities
{
    public class Song : ISong
    {
        public Song(string name, TimeSpan duration)
        {
            this.Name = name;
            this.Duration = duration;
        }

        public string Name { get; }

        public TimeSpan Duration { get; }

        public override string ToString()
        {
            return $"{this.Name} ({this.Duration:mm\\:ss})";
        }
    }
}
