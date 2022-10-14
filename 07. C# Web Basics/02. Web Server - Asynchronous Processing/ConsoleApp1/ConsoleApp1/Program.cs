using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                var task = Task.Run(() =>
                {
                    var x = i;
                    for (int j = 0; j < 100000; j++)
                    {
                        Task.Run(() => Console.WriteLine($"{x}  => {Thread.CurrentThread.ManagedThreadId}"));
                    }
                });
                //task.Wait();
                //task.Exception
                //task.IsCanceled
            }
            //8-1
            Console.ReadLine();
        }

        static async Task SumNumbersAsync(int max)
        {
            try
            {
                var lines = await File.ReadAllLinesAsync("temp.txt");
                await File.WriteAllLinesAsync("temp2.txt", lines);
                Console.WriteLine(lines[0]);
            }
            catch
            {

            }
        }
    }
}
