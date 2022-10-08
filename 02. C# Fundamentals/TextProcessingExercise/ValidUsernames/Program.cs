using System;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            StringBuilder validUsername = new StringBuilder();
            for (int i = 0; i < userNames.Length; i++)
            {
                string user = userNames[i];
                if (user.Length <= 3 || user.Length >= 16)
                {
                    continue;
                }
                for (int j = 0; j < user.Length; j++)
                {
                    char symbol = user[j];
                    if (char.IsLetter(symbol) || char.IsDigit(symbol) || symbol == '-' || symbol == '_')
                    {
                        validUsername.Append(symbol);
                    }
                    else
                    {
                        validUsername.Clear();
                        break;
                    }
                }
                if (validUsername.Length > 0)
                {
                    Console.WriteLine(validUsername);
                    validUsername.Clear();
                }
            }
        }
    }
}
