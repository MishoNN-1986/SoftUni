﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._BarraksWars_ANewFactory.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}
