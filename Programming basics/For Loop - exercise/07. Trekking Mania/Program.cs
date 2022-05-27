using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupQuantity = int.Parse(Console.ReadLine());
            double Musala = 0;
            double Monblan = 0;
            double Kilimandharo = 0;
            double K2 = 0;
            double Everest = 0;
            for (int i = 1; i <= groupQuantity; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup <= 5)
                {
                    Musala += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    Monblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    Kilimandharo += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    K2 += peopleInGroup;
                }
                else
                {
                    Everest += peopleInGroup;
                }
            }
            double allPeople = Musala + Monblan + Kilimandharo + K2 + Everest;
            Musala = Musala / allPeople * 100;
            Monblan = Monblan / allPeople * 100;
            Kilimandharo = Kilimandharo / allPeople * 100;
            K2 = K2 / allPeople * 100;
            Everest = Everest / allPeople * 100;

            Console.WriteLine($"{Musala:f2}%");
            Console.WriteLine($"{Monblan:f2}%");
            Console.WriteLine($"{Kilimandharo:f2}%");
            Console.WriteLine($"{K2:f2}%");
            Console.WriteLine($"{Everest:f2}%");
        }
    }
}
