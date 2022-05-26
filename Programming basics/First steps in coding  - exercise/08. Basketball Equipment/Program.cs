using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricePerYear = int.Parse(Console.ReadLine());
            double sneakers = pricePerYear - pricePerYear * 0.4;
            double outfit = sneakers - sneakers * 0.2;
            double ball = outfit / 4;
            double accesсories = ball / 5;
            double expenses = pricePerYear + sneakers + outfit + ball + accesсories;
            Console.WriteLine(expenses);
        }
    }
}
