using _04._Observer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Contracts
{
    public interface IHandler
    {
        void Handle(LogType type, string message);

        void SetSuccessor(IHandler handler);
    }
}
