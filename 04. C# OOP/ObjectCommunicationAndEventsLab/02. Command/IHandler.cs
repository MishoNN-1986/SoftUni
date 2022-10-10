using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Command
{
    public interface IHandler
    {
        void Handle(LogType type, string message);

        void SetSuccessor(IHandler handler);
    }
}
