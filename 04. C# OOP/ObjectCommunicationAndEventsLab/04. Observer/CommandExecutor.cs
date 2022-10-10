using _04._Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer
{
    public class CommandExecutor : IExecutor
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
