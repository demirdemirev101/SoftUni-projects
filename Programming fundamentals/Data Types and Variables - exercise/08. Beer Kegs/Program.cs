using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            double volume = 0;
            double biggestBeg = double.MinValue;
            string modelOfTheBiggestBeg = "";
            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (biggestBeg < volume)
                {
                    biggestBeg = volume;
                    modelOfTheBiggestBeg = model;
                }
            }
            Console.WriteLine(modelOfTheBiggestBeg);
        }
    }
}
