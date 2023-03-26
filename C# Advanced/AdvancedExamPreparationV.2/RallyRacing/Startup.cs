using System;
using System.Linq;

namespace RallyRacing
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            string numberOfTheCar =Console.ReadLine();
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] rows = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = rows[col];
                }
            }

            bool dunePassed = false;
        bool isFinished=false;
            int currentRow = 0;
            int currentCol = 0;
            int kmPassed = 0;
            
            string command = Console.ReadLine();
            while (command!="End")
            {
                    switch (command)
                    {
                        case "left":
                            currentCol--;
                            break;
                        case "right":
                            currentCol++;
                            break;
                        case "up":
                            currentRow--;
                            break;
                        case "down":
                            currentRow++;
                            break;
                    }

                if (matrix[currentRow, currentCol] == '.')
                {
                    kmPassed += 10;
                   
                }
                else
                {
                    if (matrix[currentRow, currentCol] == 'T')
                    {
                        kmPassed += 30;
                        matrix[currentRow, currentCol] = '.';
                        for (int r = 0; r < size; r++)
                        {
                            for (int c = 0; c < size; c++)
                            {
                                if (matrix[r, c] == 'T')
                                {
                                    currentRow = r;
                                    currentCol = c;
                                    matrix[r, c] = '.';
                                    break;
                                }

                            }
                            if (dunePassed==true)
                            {
                                break;
                            }
                        }
                    }
                    else  if (matrix[currentRow, currentCol] == 'F')
                    {
                        kmPassed += 10;
                        isFinished = true;
                        break;
                       
                    }
                }
                
                command = Console.ReadLine();
            }
            
            matrix[currentRow, currentCol] = 'C';
            
            if (command=="End")
            {
                Console.WriteLine($"Racing car {numberOfTheCar} DNF.");
            }
            if (isFinished)
            {
                Console.WriteLine($"Racing car {numberOfTheCar} finished the stage!");
            }
                Console.WriteLine($"Distance covered {kmPassed} km.");


            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
