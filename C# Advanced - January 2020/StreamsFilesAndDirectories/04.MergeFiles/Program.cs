using System;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstPath = (@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\04.MergeFiles\Input1.txt");
            //var secondPath = (@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\04.MergeFiles\Input2.txt");
            string[] firstInput = File.ReadAllLines(@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\04.MergeFiles\Input1.txt");
            string[] secondInput = File.ReadAllLines(@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\04.MergeFiles\Input2.txt");
            using (var output = new StreamWriter("../../../Output.txt")) // за да запише промените в папката 3 директории на зад, иначе са само в bin
            {
                if (firstInput.Length >= secondInput.Length)
                {
                    for (int i = 0; i < firstInput.Length; i++)
                    {
                        var line = firstInput[i];
                        output.WriteLine(line);
                        Console.WriteLine(line);
                        if (secondInput.Length <= firstInput.Length)
                        {
                            line = secondInput[i];
                            output.WriteLine(line);
                            Console.WriteLine(line);
                        }
                       
                    }
                }
            }
            
        }
    }
}
