using _05._BarracksWars_ReturnOfTheDependencies.Contracts;
using _05._BarracksWars_ReturnOfTheDependencies.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data)
            : base(data)
        {
        }

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
