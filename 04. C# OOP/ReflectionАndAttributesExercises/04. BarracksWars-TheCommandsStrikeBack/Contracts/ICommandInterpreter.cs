using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BarracksWars_TheCommandsStrikeBack.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}
