using _03._Mediator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Contracts
{
    public interface IHandler
    {
        void Handle(LogType type, string message);

        void SetSuccessor(IHandler handler);
    }
}
