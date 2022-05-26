using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPackagesForDogs = int.Parse(Console.ReadLine());
            int numOfPackagesForCats = int.Parse(Console.ReadLine());
            Console.WriteLine($" {numOfPackagesForDogs * 2.50 + numOfPackagesForCats * 4} lv.");
        }
    }
}
