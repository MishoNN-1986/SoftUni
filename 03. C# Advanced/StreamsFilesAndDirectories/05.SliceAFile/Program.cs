using System;
using System.IO;
using System.Linq;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new FileStream("Text.txt", FileMode.OpenOrCreate)) // using гарантира, че след използването на текучия файл, ще го затвори и ще спре да използва заделените ресурси за него. Изпозлването на файл е парче по парче(редове или парчета), защото ако е мн голям и се чете целия ще забие програмата.
            {
                var parts = 4;
                var length = (int)Math.Ceiling(stream.Length / (decimal)parts);
                var buffer = new byte[length];
                for (int i = 0; i < parts; i++)
                {
                    var bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead < buffer.Length)
                    {
                        buffer = buffer
                            .Take(bytesRead)
                            .ToArray();
                    }
                    using (var currentPartStream = new FileStream($"Part{i + 1}.txt", FileMode.OpenOrCreate)) //създаваме 4 файла в C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\05.SliceAFile\bin\Debug\netcoreapp2.1
                    {
                        currentPartStream.Write(buffer, 0, buffer.Length);
                    }
                }
                //Console.WriteLine(stream.Length);
            }
        }
    }
}
