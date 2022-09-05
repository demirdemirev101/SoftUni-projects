using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numNegativeGradesAllowed = int.Parse(Console.ReadLine());
            int solvedProblems = 0;
            int unsolvedProblems = 0;
            double sum = 0;
            bool isFalse = true;
            string lastName = string.Empty;
            while (unsolvedProblems < numNegativeGradesAllowed)
            {
                string exerciseName = Console.ReadLine();
                if (exerciseName == "Enough")
                {
                    isFalse = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    unsolvedProblems++;

                }
                else
                {
                    solvedProblems++;
                }
                sum += grade;
                lastName = exerciseName;
            }
            sum = sum / (unsolvedProblems + solvedProblems);

            if (isFalse)
            {
                Console.WriteLine($"You need a break, {unsolvedProblems} poor grades.");

            }
            else
            {

                Console.WriteLine($"Average score: {sum:f2}");
                Console.WriteLine($"Number of problems: {unsolvedProblems + solvedProblems}");
                Console.WriteLine($"Last problem: {lastName}");
            }
        }
    }
