using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string commandName, string[] data);
    }
}
