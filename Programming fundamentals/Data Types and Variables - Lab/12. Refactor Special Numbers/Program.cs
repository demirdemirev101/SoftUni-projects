using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                int specialNumber = 0;
                specialNumber = currentNumber;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                bool isSpecialNum = false;
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", specialNumber, isSpecialNum);
                sum = 0;
                currentNumber = specialNumber;

            }
        }
    }
}