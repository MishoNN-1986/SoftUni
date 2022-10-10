using _03._Mediator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator
{
    public class CommandExecutor : IExecutor
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
