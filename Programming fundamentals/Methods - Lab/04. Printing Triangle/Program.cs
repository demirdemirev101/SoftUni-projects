using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int j = 1; j < input; j++)
            {
                TrianglePrinting(j);
            }
            for (int i = input; i > 0; i--)
            {
                TrianglePrinting(i);

            }
        }
        static void TrianglePrinting(int j)
        {
            for (int i = 1; i <= j; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
