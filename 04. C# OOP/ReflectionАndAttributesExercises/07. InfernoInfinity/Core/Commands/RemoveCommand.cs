﻿using _07._InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Core.Commands
{
    public class RemoveCommand : Command
    {
        private IRepository repository;

        public RemoveCommand(string[] data)
            : base(data)
        {
        }

        public override void Execute()
        {
            string name = this.Data[0];
            int index = int.Parse(this.Data[1]);

            this.repository.RemoveGem(name, index);
        }
    }
}
