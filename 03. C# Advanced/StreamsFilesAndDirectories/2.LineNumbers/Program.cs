using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("Input.txt"); // може по лесно с string path = Path.Combine("data", "input.txt")
            using (reader)                              // var lines = File.ReadAllLines(path);
            {
                int count = 1;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter("../../../Output.txt")) // (....., true/false)
                {
                    while (line != null)
                    {
                        var convertedLine = ($"{count}. {line}");
                        writer.WriteLine(convertedLine);
                        count++;
                        line = reader.ReadLine();
                        Console.WriteLine(convertedLine);
                    }
                    //Console.WriteLine(string.Join(Environment.NewLine, writer));
                }
             
            }
           
        }
    }
}
