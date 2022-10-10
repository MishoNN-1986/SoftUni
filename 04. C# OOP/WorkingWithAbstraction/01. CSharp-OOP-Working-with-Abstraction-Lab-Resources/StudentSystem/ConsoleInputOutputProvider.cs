using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class ConsoleInputOutputProvider : IInputOutputProvider
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void GetOutPut(string data)
        {
            Console.WriteLine(data);
        }
    }
}
