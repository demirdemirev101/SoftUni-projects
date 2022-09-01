using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            const int CAPACITY = 255;
            int sumCapacity = CAPACITY;
            for (int i = 0; i < numberOfLines; i++)
            {
                int waterQuantities = int.Parse(Console.ReadLine());


                if (sumCapacity - waterQuantities < 0)
                {
                    Console.WriteLine("Insufficient capacity!");


                }
                else
                {
                    sumCapacity -= waterQuantities;
                }


            }
            int totalFieldQuantity = CAPACITY - sumCapacity;
            Console.WriteLine(totalFieldQuantity);
        }
    }
}
