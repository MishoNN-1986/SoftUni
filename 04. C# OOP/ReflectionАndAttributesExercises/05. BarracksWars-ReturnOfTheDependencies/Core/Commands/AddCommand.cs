using _05._BarracksWars_ReturnOfTheDependencies.Contracts;
using _05._BarracksWars_ReturnOfTheDependencies.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;

        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public AddCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
