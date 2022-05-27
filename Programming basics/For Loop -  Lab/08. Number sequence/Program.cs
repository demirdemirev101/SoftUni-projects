using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int nValue = int.Parse(Console.ReadLine());
                if (maxNumber < nValue)
                {
                    maxNumber = nValue;
                }
                if (minNumber > nValue)
                {
                    minNumber = nValue;
                }

            }
            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Min number: " + minNumber);

        }
    }
}
