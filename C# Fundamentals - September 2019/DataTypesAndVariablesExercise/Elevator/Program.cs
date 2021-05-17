using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            if (numberOfPeople % capacity == 0)
            {
                courses = numberOfPeople / capacity;
            }
            else
            {
                courses = numberOfPeople / capacity + 1;
            }
            Console.WriteLine(courses);
        }
    }
}
