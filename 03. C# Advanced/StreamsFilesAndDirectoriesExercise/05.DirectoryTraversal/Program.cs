using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDirectory = Console.ReadLine();
            string[] files = Directory.GetFiles(inputDirectory);
            Dictionary<string, Dictionary<string, double>> info = new Dictionary<string, Dictionary<string, double>>();
            foreach (var filePath in files)
            {
                string fileName = filePath
                    .Split("\\")
                    .Last();
                string ext = fileName
                    .Split(".")
                    .Last();
                var fileInfo = new FileInfo(fileName);
                double fileSize = fileInfo.Length / 1000.0;
                if (!info.ContainsKey(ext))
                {
                    info.Add(ext, new Dictionary<string, double>());
                }
                if (!info[ext].ContainsKey(fileName))
                {
                    info[ext].Add(fileName, fileSize);
                }
            }
            info = info.OrderByDescending(k => k.Value.Count).ToDictionary(k => k.Key, v => v.Value); //.ThenBy(v=>v.Value.Values)
            StringBuilder output = new StringBuilder();
            foreach (var (item, value) in info)
            {
                output.Append($".{item} {Environment.NewLine}");
                foreach (var valueInfo in value.OrderByDescending(v => v.Value))
                {
                    output.Append($"--{valueInfo.Key} - {valueInfo.Value:F3}kb {Environment.NewLine}");
                }
            }
            Console.WriteLine(output.ToString().TrimEnd());
            File.WriteAllText("../../../report.txt",output.ToString().TrimEnd());
           //на конзолата си въвеждаме произволен път (. или ../../../ и т.н.)
        }
    }
}
