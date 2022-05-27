using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNum = int.MinValue;
            int num = 0;
            while (command != "Stop")
            {
                num = int.Parse(command);
                if (maxNum < num)
                {
                    maxNum = num;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
