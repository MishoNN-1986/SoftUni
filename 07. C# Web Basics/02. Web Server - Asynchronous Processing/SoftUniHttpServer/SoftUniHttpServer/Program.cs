using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SoftUniHttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NewLine = "\r\n";

            //TCP protocol
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 12345); //Loopback is my local host

            tcpListener.Start();
            //WebUtility.UrlDecode

            while (true) //при всяко влизане в цикъла трябва да обработваме по 1 клиен
            {
                var client = tcpListener.AcceptTcpClient();
                using (var stream = client.GetStream())
                {
                    var requestBytes = new byte[100000];
                    var readBytes = stream.Read(requestBytes, 0, requestBytes.Length);
                    var stringRequest = Encoding.UTF8.GetString(requestBytes, 0, readBytes);
                    Console.WriteLine(new string('=', 70));
                    Console.WriteLine(stringRequest); //каквито и данни да са изпратени към tcp, ако могат да се конвертират към UTF8, ще ги изкарам на конзолата
                    //localhost:12345 in Chrome

                    //string responseBody = "<h1>Hello, user</h1>";
                    //string response = "HTTP/1.0 200 OK" + NewLine + //header
                    //                   "Server: MyCustomServer/1.0" + NewLine + //header
                    //                   $"Content-Length: {responseBody.Length}" + NewLine + NewLine + //body
                    //                   responseBody;
                    string responseBody = "<form method='post'><input type='text' name='tweet' placeholder='Enter tweet...' /><input name='name' /><input type='submit' /></form>";
                    string response = "HTTP/1.0 200 OK" + NewLine + //header
                                       "Content-Type: text/html" + NewLine +
                                       "Server: MyCustomServer/1.0" + NewLine + //header
                                       $"Content-Length: {responseBody.Length}" + NewLine + NewLine + //body
                                       responseBody;

                    var responseBytes =  Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);
                }
            }
        }
    }
}
