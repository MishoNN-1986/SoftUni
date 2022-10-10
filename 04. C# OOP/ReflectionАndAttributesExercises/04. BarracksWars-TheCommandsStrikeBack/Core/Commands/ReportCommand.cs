using _04._BarracksWars_TheCommandsStrikeBack.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BarracksWars_TheCommandsStrikeBack.Core.Commands
{
    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
