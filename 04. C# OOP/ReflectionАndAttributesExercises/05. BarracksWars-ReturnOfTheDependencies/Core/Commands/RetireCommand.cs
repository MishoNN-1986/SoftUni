using _05._BarracksWars_ReturnOfTheDependencies.Contracts;
using _05._BarracksWars_ReturnOfTheDependencies.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            var typeOfUnit = Data[1];

            try
            {
                this.repository.RemoveUnit(typeOfUnit);
                return $"{typeOfUnit} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }
    }
}
