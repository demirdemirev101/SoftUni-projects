using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;

            string book = Console.ReadLine();
            while (book != "No More Books")
            {
                if (favouriteBook == book)
                {
                    isBookFound = true;
                    break;
                }
                book = Console.ReadLine();
                counter++;


            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}