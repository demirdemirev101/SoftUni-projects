using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                string rows = Console.ReadLine();
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    matrix[col, row] = rows[row].ToString();
                }
                    
                
            }
            
            char symbol=char.Parse(Console.ReadLine());
           
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    if (matrix[c, r] == symbol.ToString())
                    {
                        Console.WriteLine($"({c}, {r})");

                        return;
                    }
                }
            }

             Console.WriteLine($"{symbol} does not occur in the matrix");
            
        }
    }
}
