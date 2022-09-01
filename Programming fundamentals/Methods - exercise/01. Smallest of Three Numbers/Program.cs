using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SmallestNumber(firstNumber, secondNumber, thirdNumber);


        }
        static void SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int minNumber = 0;
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                minNumber = firstNumber;
            }
            else if (secondNumber < thirdNumber && secondNumber < firstNumber)
            {
                minNumber = secondNumber;
            }
            else
            {
                minNumber = thirdNumber;
            }
            Console.WriteLine(minNumber);
        }
    }
}
