using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int sumOfElements = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] colElements = Console.ReadLine()
                         .Split(", ")
                         .Select(int.Parse)
                         .ToArray();
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows,columns]=colElements[columns];
                    sumOfElements += matrix[rows, columns];
                }
            }
            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            Console.WriteLine(sumOfElements);
        }
    }
}
