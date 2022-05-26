using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositMonth = int.Parse(Console.ReadLine());
            double incrPercent = double.Parse(Console.ReadLine());
            incrPercent = incrPercent / 100;
            double sum;
            sum = depositSum + depositMonth * ((depositSum * incrPercent) / 12.0);
            Console.WriteLine(sum);
        }
    }
}
