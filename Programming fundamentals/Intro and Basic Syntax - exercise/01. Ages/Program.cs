using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            if (person >= 0 && person <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (person >= 3 && person <= 13)
            {
                Console.WriteLine("child");
            }
            else if (person >= 14 && person <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (person >= 20 && person <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
