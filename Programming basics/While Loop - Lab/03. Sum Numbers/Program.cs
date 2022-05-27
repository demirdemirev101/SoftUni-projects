using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum != num && sum < num)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
