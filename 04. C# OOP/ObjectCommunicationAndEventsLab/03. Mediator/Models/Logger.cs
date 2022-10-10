using _03._Mediator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mediator.Models
{
    public abstract class Logger : IHandler
    {
        private IHandler successor;

        public abstract void Handle(LogType type, string message);

        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        protected void PassToSuccessor(LogType type, string message)
        {
            if (this.successor != null)
            {
                this.successor.Handle(type, message);
            }
        }
    }
}
