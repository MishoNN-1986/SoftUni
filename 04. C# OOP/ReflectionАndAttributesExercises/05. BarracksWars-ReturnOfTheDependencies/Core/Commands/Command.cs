using _05._BarracksWars_ReturnOfTheDependencies.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;

        protected Command(string[] data)
        {
            this.Data = data;
        }

        protected string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public abstract string Execute();
    }
}
