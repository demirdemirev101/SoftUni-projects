using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize=int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowSize][];

            for (int r = 0; r < rowSize; r++)
            {
                int[] col=Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jagged[r] = col;

            }

            string command=Console.ReadLine();
            while (command!="END")
            {
                string[] tokens = command.Split();
                string action=tokens[0];
                        int row = int.Parse(tokens[1]);
                        int column = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);
                if (row < 0 || row >= jagged.Length || column < 0 || column >= jagged.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (action)
                    {
                        case "Add":
                            jagged[row][column] += value;
                            break;
                        case "Subtract":
                            jagged[row][column] -= value;
                            break;
                    }
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
