﻿using _07._InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._InfernoInfinity.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public IExecutable InterpretCommand(string commandName, string[] data)
        {
            string name = commandName.ToUpper().First() + commandName.ToLower().Substring(1) + "Command";

            Type classType = Type.GetType(name);

            IExecutable instance = (IExecutable)Activator.CreateInstance(classType, new object[] { data });

            return instance;
        }
    }
}
