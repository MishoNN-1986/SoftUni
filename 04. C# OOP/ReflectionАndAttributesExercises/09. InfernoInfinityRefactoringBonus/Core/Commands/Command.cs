using _09._InfernoInfinityRefactoringBonus.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;

        protected Command(string[] data)
        {
            this.data = data;
        }

        protected string[] Data { get { return this.data; } }

        public abstract void Execute();
    }
}
