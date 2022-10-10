using System;

namespace _03._ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
