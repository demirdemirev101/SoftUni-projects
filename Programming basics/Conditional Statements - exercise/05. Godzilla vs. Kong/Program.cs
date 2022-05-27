using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int numStatists = int.Parse(Console.ReadLine());
            double priceForWear = double.Parse(Console.ReadLine());

            double decor = filmBudget * 0.1;
            priceForWear = numStatists * priceForWear;
            if (numStatists > 150)
            {
                priceForWear = priceForWear - priceForWear * 0.1;
            }

            double priceForRecord;
            priceForRecord = priceForWear + decor;

            if (filmBudget < priceForRecord)
            {
                filmBudget = filmBudget - priceForRecord;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(filmBudget):f2} leva more.");

            }
            else
            {
                filmBudget = filmBudget - priceForRecord;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget:f2} leva left.");
            }
        }
    }
}
