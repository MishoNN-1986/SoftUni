using System;
using System.Diagnostics;
using System.Text;
using Wintellect.PowerCollections;

namespace TestWithWintellectPowerCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 100000;
            Console.WriteLine($"Iterations: {iterations}");

            BigList<string> rope = new BigList<string>();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int i = 0; i < iterations; i++)
            {
                rope.Insert(0, "str");
            }
            Console.WriteLine($"Rope prepend time elapsed: {timer.ElapsedMilliseconds}");

            StringBuilder builder = new StringBuilder();

            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < iterations; i++)
            {
                builder.Insert(0, "str");
            }
            Console.WriteLine($"StringBuilder prepend time elapsed: {timer.ElapsedMilliseconds}");

            rope = new BigList<string>();

            builder = new StringBuilder();

            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < iterations; i++)
            {
                rope.Add("str");
            }

            Console.WriteLine($"Rope append time elapsed: {timer.ElapsedMilliseconds}");

            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < iterations; i++)
            {
                builder.Append("str");
            }
            Console.WriteLine($"StringBuilder append time elapsed: {timer.ElapsedMilliseconds}");

            rope = new BigList<string>();
            builder = new StringBuilder();

            timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < iterations; i++)
            {
                rope.Insert(rope.Count / 2, "middle");
            }
            Console.WriteLine($"Rope insert in the middle time elapsed: {timer.ElapsedMilliseconds}");

            timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < iterations; i++)
            {
                builder.Insert(builder.Length / 2, "middle");
            }
            Console.WriteLine($"Builder insert in the middle time elapsed: {timer.ElapsedMilliseconds}");
        }
    }
}
