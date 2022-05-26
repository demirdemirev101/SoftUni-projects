using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPagesInTheBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numOfDays = int.Parse(Console.ReadLine());

            numOfPagesInTheBook = numOfPagesInTheBook / pagesPerHour / numOfDays;

            Console.WriteLine(numOfPagesInTheBook);
        }
    }
}
