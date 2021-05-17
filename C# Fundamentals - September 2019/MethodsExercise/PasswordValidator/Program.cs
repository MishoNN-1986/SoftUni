using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ChekThatThePasswordIsValid(password);
        }

        static void ChekThatThePasswordIsValid(string password)
        {
            bool validPasword = true;
            int countDigits = 0;
            int lenth = password.Length;
            if (lenth < 6 || lenth > 10)
            {
                validPasword = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            for (int i = 0; i < lenth; i++)
            {
                if ((password[i] < 48 || password[i] > 57) && (password[i] < 65 || password[i] > 90) &&
                    (password[i] < 97 || password[i] > 122))  // char.IsLetterOrDigit(!password(i))
                {
                    validPasword = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
                if (password[i] >= 48 && password[i] <= 57) // char.IsDigit(password[i])
                {
                    countDigits++;
                }
            }
            if (countDigits < 2)
            {
                validPasword = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (validPasword)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
