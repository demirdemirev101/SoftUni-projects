using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string dimension1=dimensions[0];
            string dimension2=dimensions[1];
            
            string[,] matrix = new string[int.Parse(dimension1),int.Parse(dimension2)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] columns=Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col]=columns[col];
                }
            }

            string command=Console.ReadLine();
            while (command!="END")
            {
              string[] arguments=command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            
                if (!arguments.Contains("swap")||(arguments.Length>5||arguments.Length<5)
                    || (int.Parse(arguments[1]) >= int.Parse(dimension1) && int.Parse(arguments[2]) >= int.Parse(dimension2)
                    && int.Parse(arguments[3]) >= int.Parse(dimension1) && int.Parse(arguments[4]) >= int.Parse(dimension2)))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    string action=arguments[0];
                    if (action=="swap")
                    {
                        string swap ="";

                        swap=matrix[int.Parse(arguments[1]), int.Parse(arguments[2])];
                        matrix[int.Parse(arguments[1]), int.Parse(arguments[2])] = matrix[int.Parse(arguments[3]), int.Parse(arguments[4])];
                        matrix[int.Parse(arguments[3]), int.Parse(arguments[4])] = swap;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row,col]+" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                command=Console.ReadLine();
            }

        }
    }
}
