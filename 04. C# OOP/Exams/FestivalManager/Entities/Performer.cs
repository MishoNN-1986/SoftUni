using FestivalManager.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities
{
    public class Performer : IPerformer
    {
        private readonly List<IInstrument> instruments;

        public Performer(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            this.instruments = new List<IInstrument>();
        }

        public string Name { get; }

        public int Age { get; }

        public IReadOnlyCollection<IInstrument> Instruments => this.instruments;

        public void AddInstrument(IInstrument instrument)
        {
            this.instruments.Add(instrument);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
