using System;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Complete")
            {
                string[] command = input.Split();
                string operation = command[0];
                switch (operation)
                {
                    case "Make":
                        string typeLetters = command[1];
                        email = Make(email, typeLetters);
                        break;
                    case "GetDomain":
                        int count = int.Parse(command[1]);
                        GetDomain(email, count);
                        break;
                    case "GetUsername":
                        GetUsername(email);
                        break;
                    case "Replace":
                        string symbol = command[1];
                        email = Replace(email, symbol);
                        break;
                    case "Encrypt":
                        Encrypt(email);
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void Encrypt(string email)
        {
            foreach (char symbol in email)
            {
                int value = symbol;
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }

        static string Replace(string email, string symbol)
        {
            email = email.Replace(symbol, "-");
            Console.WriteLine(email);
            return email;
        }

        private static void GetUsername(string email)
        {
            if (!email.Contains("@"))
            {
                Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                return;
            }
            int index = email.LastIndexOf("@");
            string username = email.Substring(0, index);
            Console.WriteLine(username);
        }

        private static void GetDomain(string email, int count)
        {
            if (count > email.Length || count < 0)
            {
                return;
            }
            string domain = email.Substring(email.Length - count, count);
            Console.WriteLine(domain);
        }

        static string Make(string email, string typeLetters)
        {
            if (typeLetters == "Upper")
            {
                email = email.ToUpper();
            }
            else if (typeLetters == "Lower")
            {
                email = email.ToLower();
            }
            Console.WriteLine(email);
            return email;
        }
    }
}
