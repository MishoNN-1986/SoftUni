using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Command
{
    public interface IExecutor
    {
        void ExecuteCommand(ICommand command);
    }
}
