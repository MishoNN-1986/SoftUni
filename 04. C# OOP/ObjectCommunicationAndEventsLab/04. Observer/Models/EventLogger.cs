using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Models
{
    public class EventLogger : Logger
    {
        public override void Handle(LogType type, string message)
        {
            switch (type)
            {
                case LogType.EVENT:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
            }

            this.PassToSuccessor(type, message);
        }
    }
}
