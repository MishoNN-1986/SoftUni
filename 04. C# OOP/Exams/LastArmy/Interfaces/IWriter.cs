using System;
using System.Collections.Generic;
using System.Text;

namespace LastArmy.Interfaces
{
    public interface IWriter
    {
        void AppendLine(string line);
        void WriteLineAll();
    }
}
