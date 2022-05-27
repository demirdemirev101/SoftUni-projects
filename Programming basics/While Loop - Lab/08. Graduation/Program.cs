using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0;
            int counter = 0;
            while (grade <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());
                grade++;
                if (yearlyGrade < 4)
                {
                    grade--;
                    if (counter == 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    counter++;
                    continue;
                }
                sum += yearlyGrade;
            }
            double averageYearlyGrade = sum / 12;
            if (counter < 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageYearlyGrade:f2}");
            }
        }
    }
}
