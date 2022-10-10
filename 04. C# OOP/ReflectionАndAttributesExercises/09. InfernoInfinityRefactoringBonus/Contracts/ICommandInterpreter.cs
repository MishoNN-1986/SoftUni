using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string commandName, string[] data);
    }
}
