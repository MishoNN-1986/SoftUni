using FestivalManager.Core;
using FestivalManager.Core.Contracts;
using FestivalManager.Core.IO;
using FestivalManager.Core.IO.Contracts;
using System;

namespace FestivalManager
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
