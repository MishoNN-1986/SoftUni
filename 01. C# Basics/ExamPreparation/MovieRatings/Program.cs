using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumMovie = int.Parse(Console.ReadLine());
            int countMovie = 0;
            double allRating = 0;
            string highestName = "";
            string lowestName = "";
            double highestRating = 1.0;
            double lowesRating = 10.0;
            while (countMovie < sumMovie)
            {
                string nameMovie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                allRating += rating;
                countMovie++;
                if (rating > highestRating)
                {
                    highestRating = rating;
                    highestName = nameMovie;
                }
                if (rating < lowesRating)
                {
                    lowesRating = rating;
                    lowestName = nameMovie;
                }
            }
            double averageRating = allRating / countMovie * 1.0;
            Console.WriteLine($"{highestName} is with highest rating: {highestRating:F1}");
            Console.WriteLine($"{lowestName} is with lowest rating: {lowesRating:F1}");
            Console.WriteLine($"Average rating: {averageRating:F1}");
        }
    }
}
