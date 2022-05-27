using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;

            int evenSum = 0;

            for (int i = 1; i <= n; i++)

            {

                int element = int.Parse(Console.ReadLine());

                if (i % 2 == 0) evenSum += element;

                else oddSum += element;

            }

            

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else

            {
                int diff = Math.Abs(oddSum - evenSum);

                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }


        }
    }
}
