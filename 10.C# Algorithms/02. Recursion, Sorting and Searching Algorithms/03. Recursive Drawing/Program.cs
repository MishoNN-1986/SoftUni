using System;

namespace _03._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Draw(rows);
        }

        private static void Draw(int rows)
        {
            if(rows <= 0)
            {
                return;
            }
            
            Console.WriteLine(new string('*', rows));
            Draw(rows - 1);
            Console.WriteLine(new string('#', rows));
        }
    }
}
