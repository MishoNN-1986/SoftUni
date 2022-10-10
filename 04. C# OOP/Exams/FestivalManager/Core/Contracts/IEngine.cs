using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Core.Contracts
{
    public interface IEngine
    {
        void Run();

        string ProcessCommand(string input);
    }
}
