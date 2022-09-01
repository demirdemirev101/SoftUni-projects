using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variable = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int digit = 1; digit <= variable; digit++)
            {
                while (variable != 0)
                {
                    sum += variable % 10;
                    variable /= 10;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
