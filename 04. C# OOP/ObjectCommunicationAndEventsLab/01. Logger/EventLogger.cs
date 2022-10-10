using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
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
