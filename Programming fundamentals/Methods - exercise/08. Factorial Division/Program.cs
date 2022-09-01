using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            double factorial1 = Factorial(numberOne);
            double factorial2 = Factorial(numberTwo);

            FinalResult(factorial1, factorial2);
        }
        static double Factorial(int numberOne)
        {
            double factorial = 1;
            while (numberOne != 0)
            {
                factorial *= numberOne;
                numberOne--;
            }

            return factorial;
        }
        static void FinalResult(double factorial1, double factorial2) => Console.WriteLine($"{factorial1 / factorial2:f2}");
    }
}
