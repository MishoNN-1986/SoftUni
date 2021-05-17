using System;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAdres = GetInputAndSplit();
            string fullName = nameAndAdres[0] + " " + nameAndAdres[1];
            string adres = nameAndAdres[2];
            Tuple<string, string> nameAndAdresTuple = new Tuple<string, string>(fullName, adres);


            string[] nameAndLitersBeer = GetInputAndSplit();
            string name = nameAndLitersBeer[0];
            int liters = int.Parse(nameAndLitersBeer[1]);
            Tuple<string, int> nameAndLitersTuple = new Tuple<string, int>(name, liters);


            string[] intAndDouble = GetInputAndSplit();
            int integer = int.Parse(intAndDouble[0]);
            double doubleNum = double.Parse(intAndDouble[1]);
            Tuple<int, double> intAndDoubleTuple = new Tuple<int, double>(integer, doubleNum);
            Console.WriteLine(nameAndAdresTuple);
            Console.WriteLine(nameAndLitersTuple);
            Console.WriteLine(intAndDoubleTuple);
        }

        private static string[] GetInputAndSplit()
        {
            return Console.ReadLine()
                .Split();
        }
    }
}
