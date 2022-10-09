using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Any())
            {
                string[] command = Console.ReadLine().Split();
                bool isHaveSong = false;
                string operation = command[0];
                switch (operation)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = string.Empty;
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (i == command.Length - 1)
                            {
                                song += "" + command[i];
                            }
                            else
                            {
                                song += "" + command[i] + " ";
                            }
                        }
                        foreach (var item in songs)
                        {
                            if (item == song)
                            {
                                isHaveSong = true;
                            }
                        }
                        if (isHaveSong)
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
