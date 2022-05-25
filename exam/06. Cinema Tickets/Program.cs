using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = movieName = Console.ReadLine(); 
            int numTickets = 0;
            string ticket = string.Empty;
            int student = 0;
            int standard = 0;
            int kid = 0;
           
            double percentStudent = 0;
            double percentStandard = 0;
            double percentKid = 0;
            double percentageHall = 0;
            while (movieName!="Finish")
            {
               
                int seatings = int.Parse(Console.ReadLine());
                int people = 0;
                for ( int  i = 1; i<=seatings; i++)
                {
                     ticket = Console.ReadLine();

                    if (ticket=="student")
                    {
                        student++;
                        numTickets++;
                    }
                    else if (ticket=="standard")
                    {
                        standard++;
                        numTickets++;
                    }
                    else if (ticket=="kid")
                    {
                        kid++;
                        numTickets++;
                    }
                    else  if (ticket == "End")
                    {

                        break;
                    }

                    people++;
                }

                percentageHall = people*1.0/seatings *100.0;
                Console.WriteLine($"{movieName} - {percentageHall:f2}% full.");
                movieName = Console.ReadLine();
            }
            percentStudent = student * 1.0 / numTickets * 100;
            percentStandard = standard * 1.0 / numTickets * 100;
            percentKid = kid * 1.0 / numTickets * 100;

            Console.WriteLine($"Total tickets: {numTickets}");
            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKid:f2}% kids tickets.");
        }
    }
}
