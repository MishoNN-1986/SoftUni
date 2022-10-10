using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Command
{
    public class CombatLogger : Logger
    {
        public override void Handle(LogType type, string message)
        {
            switch (type)
            {
                case LogType.ATTACK:
                case LogType.MAGIC:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
            }

            this.PassToSuccessor(type, message);
        }
    }
}
