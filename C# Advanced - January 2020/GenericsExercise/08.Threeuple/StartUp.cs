using System;

namespace _08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAdres = GetInputAndSplit();
            string fullName = nameAndAdres[0] + " " + nameAndAdres[1];
            string adres = nameAndAdres[2];
            string town = nameAndAdres[3];
            Threeuple<string, string, string> nameAndAdresTuple = new Threeuple<string, string, string>(fullName, adres, town);


            string[] nameAndLitersBeer = GetInputAndSplit();
            string name = nameAndLitersBeer[0];
            int liters = int.Parse(nameAndLitersBeer[1]);
            bool isDrunk = false;
            if (nameAndLitersBeer[2] == "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, int, bool> nameAndLitersTuple = new Threeuple<string, int, bool>(name, liters, isDrunk);


            string[] nameAndBank = GetInputAndSplit();
            string firstName = nameAndBank[0];
            double balance = double.Parse(nameAndBank[1]);
            string bankName = nameAndBank[2];
            Threeuple<string, double, string> nameAndBankTuple = new Threeuple<string, double, string>(firstName, balance, bankName);

            Console.WriteLine(nameAndAdresTuple);
            Console.WriteLine(nameAndLitersTuple);
            Console.WriteLine(nameAndBankTuple);
        }

        private static string[] GetInputAndSplit()
        {
            return Console.ReadLine()
                .Split();
        }

    }
}
