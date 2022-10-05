using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columns = Console.ReadLine()
                    .Split().Select(int.Parse)
                    .ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row,column]= columns[column];
                }
            }
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        sum += matrix[i,j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
