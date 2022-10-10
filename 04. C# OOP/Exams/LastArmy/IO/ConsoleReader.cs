using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
