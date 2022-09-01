using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            double sum = SumOfFirstAndSecondNumber(firstNumber, secondNumber);
            SubstractionBetweenSumAndThirdNumber(sum, thirdNumber);
        }
        static double SumOfFirstAndSecondNumber(int first, int second)
        {
            double sum = first + second;
            return sum;
        }
        static void SubstractionBetweenSumAndThirdNumber(double sum, int third)
        {
            double result = sum - third;
            Console.WriteLine(result);
        }
    }
}
