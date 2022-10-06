using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string catNameOne = Console.ReadLine();
            string catNameTwo = Console.ReadLine();
            string dogNameOne = Console.ReadLine();
            string dogNameTwo = Console.ReadLine();
            // Option 1
            Console.WriteLine("My name is " + name + " and I have cats and dogs and their names are: cat name one - " + catNameOne + ", cat name two -" + catNameTwo + ", dog name one -" + dogNameOne + ", dog name two - " + dogNameTwo );
            // Option 2
            Console.WriteLine("My name is {0} and I have cats and dogs and their name are : cat name one - {1}, cat name two - {2}, dog name one - {3}, dog name two - {4}", name, catNameOne, catNameTwo, dogNameOne, dogNameTwo);
            // Option 3
            Console.WriteLine($"My name is {name} and I have cats and dogs and their names are : cat name one - {catNameOne}, cat name two - {catNameTwo}, dog name one - {dogNameOne}, dog name two - {dogNameTwo}");
        }
    }
}
