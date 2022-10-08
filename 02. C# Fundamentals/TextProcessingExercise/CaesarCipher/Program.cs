using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = (char)(text[i] + 3);
                encryptedText.Append(symbol);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
