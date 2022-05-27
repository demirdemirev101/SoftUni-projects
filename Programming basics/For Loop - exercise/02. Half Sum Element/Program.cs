using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum = n + sum;
                if (max < n)
                {
                    max = n;
                }
            }
            int halfSum = sum - max;

            if (halfSum == max)
            {
                Console.WriteLine("Yes");

                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - halfSum)}");
            }
        }
    }
}
