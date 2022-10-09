using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectoriesExercise\06.ZipAndExtract\copyMe", 
                @"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectoriesExercise\06.ZipAndExtract\MyArchive.zip");

            // файла трябва да ни е в отделна папка, за да вземе само него
            // трябва да дадем име на файла, който се създава (MyArchive.zip)

            ZipFile.ExtractToDirectory(@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectoriesExercise\06.ZipAndExtract\MyArchive.zip",
                @"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectoriesExercise\06.ZipAndExtract\copyMeResult");

            // архива трябва да е в друга директория
            // за да работим със ZipFile, трябва да заредим VS с администраторски права
            // https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-compress-and-extract-files

        }
    }
}
