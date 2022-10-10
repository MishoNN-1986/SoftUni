using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public interface IHandler
    {
        void Handle(LogType type, string message);

        void SetSuccessor(IHandler handler);
    }
}
