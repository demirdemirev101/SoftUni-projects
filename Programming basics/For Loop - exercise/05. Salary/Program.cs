using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOpenedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOpenedTabs; i++)
            {
                string nameSite = Console.ReadLine();
                if (nameSite == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (nameSite == "Instagram")
                {
                    salary -= 100;
                }
                else if (nameSite == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
