using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] splitNumbers = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                splitNumbers[i] = number;
            }
            for (int i = splitNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(splitNumbers[i] + " ");
            }
        }
    }
}
