using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieNum = int.Parse(Console.ReadLine());
            double sum = 0;
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            string maxName = string.Empty;
            string minName = string.Empty;
            for (int movie = 1; movie <= movieNum; movie++)
            {
                string name=Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sum += rating;
                if (maxRating < rating)
                {
                    maxRating = rating;
                    maxName = name;
                }
                else if(minRating>rating)
                {
                    minRating = rating;
                    minName = name;
                }
            }
            sum /= movieNum;

            Console.WriteLine($"{maxName} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minName} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {sum:f1}");
        }
    }
}
