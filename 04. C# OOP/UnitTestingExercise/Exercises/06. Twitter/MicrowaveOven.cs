using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public class MicrowaveOven : IClient
    {

        public void WriteToConsole(string msg)
        {
            Console.WriteLine(msg);
        }

        public void SendToServer(string msg)
        {

        }
    }
}
