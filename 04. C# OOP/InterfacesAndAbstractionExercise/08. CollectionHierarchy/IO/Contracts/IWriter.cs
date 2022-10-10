using System;
using System.Collections.Generic;
using System.Text;

namespace _08._CollectionHierarchy.IO.Contracts
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine();

        void WriteLine(string text);
    }
}
