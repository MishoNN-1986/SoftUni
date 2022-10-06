using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstName = Console.ReadLine();
            string mySecondName = Console.ReadLine();
            //Option 1
            Console.WriteLine("My name is " + myFirstName + " " + mySecondName);
            Console.WriteLine("My first name is " + myFirstName + " and my second name is " + mySecondName);
            //Option 2
            Console.WriteLine("My first name is {0} and my second name is {1}", myFirstName, mySecondName);
            //Option 3
            Console.WriteLine($"My first name is {myFirstName} and my second name is {mySecondName}");

        }
    }
}
