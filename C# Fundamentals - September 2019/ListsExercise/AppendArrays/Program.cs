using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .Select(text => text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(list => string.Join(" ", list));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
