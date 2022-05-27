using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double WashingMachinePrice = double.Parse(Console.ReadLine());
            int ToyPrice = int.Parse(Console.ReadLine());

            double money = 0;
            for (int i = 1; i <= ageOfLily; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += ToyPrice;

                }
            }

            if (money >= WashingMachinePrice)
            {
                Console.WriteLine($"Yes! {money - WashingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {WashingMachinePrice - money:f2}");
            }
        }
    }
}
