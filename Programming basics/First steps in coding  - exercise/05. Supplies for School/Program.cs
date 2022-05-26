using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int abstergent = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double money = (pens * 5.80 + markers * 7.20 + abstergent * 1.20) - ((pens * 5.80 + markers * 7.20 + abstergent * 1.20) * percent / 100);
            Console.WriteLine(money);
        }
    }
}
