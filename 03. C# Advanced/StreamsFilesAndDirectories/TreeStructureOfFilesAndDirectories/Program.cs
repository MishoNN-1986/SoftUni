using System;
using System.IO;

namespace TreeStructureOfFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\SoftUni\C# Advanced-january 2020";
            PrintDirectory(path, string.Empty);
        }

        static void PrintDirectory(string path, string prefix)
        {
            var directories = Directory.GetDirectories(path); //взима всички директории
            var directoryInfo = new DirectoryInfo(path);
            Console.WriteLine($"{prefix} Dir: {directoryInfo.Name}"); //принтира ги (само имената), може направо directories

            foreach (var directory in directories) //за всяка 1 директория извиква същото
            {
                // рекурсия
                PrintDirectory(directory, prefix += "--"); //колкото по на дълбоко влиза в дървото, толкова повече тирета ще има отпред
            }
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file); //съдържа информация за файла
                Console.WriteLine($"{prefix}- File: {fileInfo.Name}"); //принтира всички файлове (само имена им), може направо file
            }
        }
    }
}
