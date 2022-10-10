using System;

namespace _02._Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Pesho");
            Bear bear = new Bear("Baba Meca");
            Animal gorilla = new Gorilla("Gori");
            Console.WriteLine($"{animal}, {bear}, {gorilla}");
        }
    }
}
