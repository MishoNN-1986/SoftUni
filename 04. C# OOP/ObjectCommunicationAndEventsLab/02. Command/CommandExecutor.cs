using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Command
{
    public class CommandExecutor : IExecutor
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
