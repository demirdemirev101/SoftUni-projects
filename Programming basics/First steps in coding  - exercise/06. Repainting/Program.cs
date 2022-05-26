using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumBags = 0.40;
            double sumEmployees;
            double sumMaterials;
            double sum;
            sumMaterials = (nylon + 2) * 1.50 + (paint + paint * 0.1) * 14.50 + (diluent * 5.00) + sumBags;
            sumEmployees = (sumMaterials * 0.3) * hours;
            sum = sumEmployees + sumMaterials;
            Console.WriteLine(sum);
        }
    }
}
