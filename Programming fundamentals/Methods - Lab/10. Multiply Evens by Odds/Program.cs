using System;


namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int evenSum = GetSumOfOdds(Math.Abs(number));
            int oddSum = GetSumOfEvens(Math.Abs(number));
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }
        static int GetSumOfEvens(int number)
        {
            int sumOfEvens = 0;
            int digits = number;
            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 == 0)
                {
                    sumOfEvens += currentDigit;
                }
                digits /= 10;
            }
            return sumOfEvens;
        }
        static int GetSumOfOdds(int number)
        {
            int sumOfOdds = 0;
            int digits = number;
            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 != 0)
                {
                    sumOfOdds += currentDigit;
                }
                digits /= 10;
            }
            return sumOfOdds;
        }
        static int GetMultipleOfEvenAndOdds(int sumOfEvens, int SumOfOdds)
        {
            int result = 1;
            result = sumOfEvens * SumOfOdds;
            return result;
        }
    }
}
