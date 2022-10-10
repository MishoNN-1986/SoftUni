using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public class Tweet
    {
        private IClient client;

        public Tweet(IClient client)
        {
            this.client = client;
        }

        public void ReceiveMessage(string message)
        {
            client.WriteToConsole(message);
            client.SendToServer(message);
        }
    }
}
