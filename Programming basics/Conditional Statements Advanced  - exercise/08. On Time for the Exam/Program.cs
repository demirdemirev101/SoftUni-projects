using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            int diff = Math.Abs(examMin - arrivalMin);
            int diffMin = diff % 60;
            int diffHour = diff / 60;

            if (arrivalMin > examMin)
            {
                Console.WriteLine("Late");
                if (diffHour < 1)
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
                else if (diffHour >= 1)
                {
                    if (diffMin > 10)
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");
                    }
                }
            }
            else if (examMin == arrivalMin || examMin - arrivalMin <= 30)
            {
                Console.WriteLine("On time");
                if (diffMin <= 30)
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
            }
            else if (examMin - arrivalMin > 30)
            {
                Console.WriteLine("Early");
                if (diffHour >= 1)
                {
                    if (diffMin > 10)
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");
                    }
                }
                else if (diffHour < 1)
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
            }
        }
    }
}
