using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int countLength = 0;
            int countIncorect = 0;
            while (true)
            {
                string word = Console.ReadLine();
                for (int i = 0; i < password.Length; i++)
                {
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        if (password[i] == word[j])
                        {
                            countLength++;
                            i++;
                            if (countLength == password.Length - 1)
                            {
                                Console.WriteLine($"User {password} logged in.");
                                return;
                            }
                        }
                    }
                    countLength = 0;
                    Console.WriteLine("Incorrect password. Try again.");
                    countIncorect++;
                    if (countIncorect == 3)
                    {
                        Console.WriteLine($"User {password} blocked!");
                        return;
                    }
                    break;
                }
            }
        }
    }
}
