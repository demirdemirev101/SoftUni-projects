using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Matrix(number);
        }
        static void Matrix(int number)
        {
            for (int rows = 0; rows < number; rows++)
            {


                for (int columns = 0; columns < number; columns++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
