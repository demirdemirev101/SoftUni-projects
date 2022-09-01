using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strongNum = int.Parse(Console.ReadLine());
            int copyStrongNum = strongNum;
            int sum = 0;

            while (strongNum > 0)
            {
                int fact = 1;
                int currentNum = strongNum % 10;
                strongNum /= 10;

                for (int i = 2; i <= currentNum; i++)
                {
                    fact *= i;
                }
                sum += fact;
            }
            if (sum == copyStrongNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}