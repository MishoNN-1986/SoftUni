﻿using LastArmy.Core;
using LastArmy.IO;
using System;

namespace LastArmy
{
    public class LastArmyMain
    {
        static void Main()
        {
            var engine = new Engine(new ConsoleReader(), new ConsoleWriter());
            engine.Run();
        }
    }
}
