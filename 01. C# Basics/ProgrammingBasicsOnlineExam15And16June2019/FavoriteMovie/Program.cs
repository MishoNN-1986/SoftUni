using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumBestMoovie = 0;
            string nameBestMoovie = "";
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= 7; i++)
            {
                string name = Console.ReadLine();
                if (name == "STOP")
                {
                    break;
                }
                for (int j = 0; j < name.Length; j++)
                {
                    sum += (int)name[j];
                    if (name[j] >= 97 && name[j] <= 122)
                    {
                        sum -= (name.Length * 2);
                    }
                    else if (name[j] >= 65 && name[j] <= 90)
                    {
                        sum -= name.Length;
                    }
                }
                if (sum > sumBestMoovie)
                {
                    sumBestMoovie = sum;
                    nameBestMoovie = name;
                }
                sum = 0;
                count++;
            }
            if (count == 7)
            {
                Console.WriteLine("The limit is reached.");
            }
            Console.WriteLine($"The best movie for you is {nameBestMoovie} with {sumBestMoovie} ASCII sum.");
        }
    }
}
