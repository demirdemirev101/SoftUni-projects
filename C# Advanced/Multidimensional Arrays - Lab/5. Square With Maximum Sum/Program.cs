using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size=Console.ReadLine()
                .Split(", ").Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0],size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columns=Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = columns[col];

                }
            }

            int maxSum = 0;
            int sum = 0;
            int squareStartRow = 0;
            int squareStartCol = 0;
           
            for (int r = 0; r < matrix.GetLength(0)-1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1)-1; c++)
                {
                    sum = 0;
                    sum += matrix[r,c];
                    sum += matrix[r+1,c];
                    sum+=matrix[r,c+1];
                    sum += matrix[r+1,c+1];
                    if (maxSum<sum)
                    {
                        squareStartRow = r;
                        squareStartCol = c;

                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine($"{matrix[squareStartRow,squareStartCol]} {matrix[squareStartRow,squareStartCol+1]}");
            Console.WriteLine($"{matrix[squareStartRow+1,squareStartCol]} {matrix[squareStartRow+1,squareStartCol+1]}");
          
            Console.WriteLine(maxSum);
        }
    }
}
