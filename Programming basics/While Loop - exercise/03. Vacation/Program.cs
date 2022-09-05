using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForTour = double.Parse(Console.ReadLine());
            double moneyAvaliable=double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int days = 0;
            string command=Console.ReadLine();
            while (true)
            {
                days++;
                if (command=="spend")
                {
                    double spend = double.Parse(Console.ReadLine());
                    
                    if (moneyAvaliable-spend<=0)
                    {
                        moneyAvaliable = 0;
                        
                       
                    }
                    else
                    {
                        moneyAvaliable -= spend;
                    }
                    spendingCounter++;
                }
                else if (command=="save")
                {
                    spendingCounter = 0;
                    double save = double.Parse(Console.ReadLine());
                    moneyAvaliable += save;
                   

                }
                if (moneyAvaliable>=moneyForTour)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
                if (spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
