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
            int sumMovies = int.Parse(Console.ReadLine());
            double maxRating = 0.0;
            double minRating = 11.0;
            string maxRatingName = "";
            string minRatingName = "";
            double countRating = 0.0;
            for (int i = 0; i < sumMovies; i++)
            {
                string name = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                countRating += rating;
                if (rating > maxRating)
                {
                    maxRating = rating;
                    maxRatingName = name;
                }
                if (rating < minRating)
                {
                    minRating = rating;
                    minRatingName = name;
                }
            }
            Console.WriteLine($"{maxRatingName} is with highest rating: {maxRating:F1}");
            Console.WriteLine($"{minRatingName} is with lowest rating: {minRating:F1}");
            Console.WriteLine($"Average rating: {countRating / sumMovies:F1}");
        }
    }
}
