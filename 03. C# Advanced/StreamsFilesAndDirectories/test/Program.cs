using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("."); // може вместо . да е път
            foreach (var item in files)
            {
                Console.WriteLine(item); // всички файлове в директорията на test
            }
        }
    }
}
