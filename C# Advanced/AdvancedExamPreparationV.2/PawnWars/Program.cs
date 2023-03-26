using System;
using System.Linq;

namespace PawnWars
{
    public class Startup
    {
        static void Main(string[] args)
        {
           
            int blackRow = 0;
            int blackCol = 0;
           
            int whiteRow = 0;
            int whiteCol = 0;


            int size = 8;
            char[,] chessBoard = new char[size,size];

            for (int row = 0; row < size; row++)
            {
                string column = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    chessBoard[row, col] = column[col];

                    if (chessBoard[row, col] == 'w')
                    {

                        whiteRow = row;
                        whiteCol = col;
                    }

                    if (chessBoard[row, col] == 'b')
                    {
                        
                        blackRow = row;
                        blackCol = col;
                    }
                    
                }
            }

            bool whiteTurn = true;
            while (true)
            {
                if (whiteTurn)
                {
                    if (whiteRow == 0)
                    {

                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(97 + whiteCol)}8.");

                        return;
                    }

                    if (IsValid(whiteRow - 1, whiteCol + 1, chessBoard) && chessBoard[whiteRow - 1, whiteCol + 1] == 'b')
                    {
                        whiteRow--;
                        whiteCol++;
                        Console.WriteLine($"Game over! White capture on {(char)(97 + whiteCol)}{8 - whiteRow}.");

                        return;
                    }
                    if (IsValid(whiteRow - 1, whiteCol - 1, chessBoard) && chessBoard[whiteRow - 1, whiteCol - 1] == 'b')
                    {
                        whiteRow--;
                        whiteCol--;
                        Console.WriteLine($"Game over! White capture on {(char)(97+ whiteCol)}{8 - whiteRow}.");

                        return;
                    }
                    whiteRow--;
                    chessBoard[whiteRow, whiteCol] = 'w';
                }
                else
                {
                     if (blackRow == 7)
                     {

                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(97+blackCol)}1.");

                        return;
                     }   

                    if (IsValid(blackRow + 1, blackCol - 1, chessBoard) && chessBoard[blackRow + 1, blackCol - 1] == 'w')
                    {
                        blackRow++;
                        blackCol--;
                        Console.WriteLine($"Game over! Black capture on {(char)(97 + blackCol)}{8-blackRow}.");

                        return;
                    }
                    if (IsValid(blackRow + 1, blackCol + 1, chessBoard) && chessBoard[blackRow + 1, blackCol + 1] == 'w')
                    {
                        blackRow++;
                        blackCol++;
                        Console.WriteLine($"Game over! Black capture on {(char)(97 + blackCol)}{8-blackRow}.");

                        return;
                    }
                    blackRow++;
                    chessBoard[blackRow, blackCol] = 'b';
                }
                    whiteTurn = !whiteTurn;
            }
        }
        static  bool IsValid(int row, int col, char[,] matrix)
        {
            return row >= 0
            && row < matrix.GetLength(0)
            && col >= 0
            && col < matrix.GetLength(1);
        }
    }
}
