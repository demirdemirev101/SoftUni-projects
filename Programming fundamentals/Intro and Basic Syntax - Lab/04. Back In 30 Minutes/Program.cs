using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMin = hours * 60 + minutes + 30;

            minutes = newMin % 60;
            hours = newMin / 60;

            if (minutes > 60)
            {
                hours += 1;
            }
            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
