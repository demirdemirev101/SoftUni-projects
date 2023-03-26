using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();
            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] columns=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => char.Parse(n))
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            int count = 0;
            for (int r = 0; r < matrix.GetLength(0)-1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1)-1; c++)
                {
                    if (matrix[r,c] == matrix[r+1,c]
                        && matrix[r,c] == matrix[r+1,c+1]
                        && matrix[r, c] == matrix[r, c+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
