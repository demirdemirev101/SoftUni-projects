using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height][];
            triangle[0] = new long[1] { 1 };
            for (long row = 1; row < height; row++)
            {

                triangle[row] = new long[triangle[row - 1].Length + 1];

                for (int col = 0; col < triangle[row].Length; col++)
                {
                    if (triangle[row - 1].Length > col)
                    {
                        triangle[row][col] += triangle[row - 1][col];
                    }
                    if (col > 0)
                    {
                        triangle[row][col] += triangle[row - 1][col - 1];

                    }
                }
            }

            PrintTriangle(triangle);

        }

        static void PrintTriangle(long[][] triangle)
        {
            for (long i = 0; i < triangle.GetLength(0); i++)
            {
                for (long j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
