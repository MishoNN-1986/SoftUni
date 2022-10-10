using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public interface IClient
    {
        void SendToServer(string msg);
        void WriteToConsole(string msg);
    }
}
