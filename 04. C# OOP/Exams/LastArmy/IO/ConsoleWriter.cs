using LastArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder stringBuilder;
        public ConsoleWriter()
        {
            stringBuilder = new StringBuilder();
        }

        public void AppendLine(string line)
        {
            stringBuilder.AppendLine(line);
        }

        public void WriteLineAll()
        {
            Console.WriteLine(stringBuilder.ToString().Trim());
        }
    }
}
