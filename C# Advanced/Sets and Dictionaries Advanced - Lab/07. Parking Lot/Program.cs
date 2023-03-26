using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            string input=Console.ReadLine();
            while (input!="END")
            {
                string[] arguments = input.Split(", ");
                string action = arguments[0];
                string car = arguments[1];
                if (action=="IN")
                {
                    parkingLot.Add(car);
                }
                else
                {
                    parkingLot.Remove(car);
                }
                input = Console.ReadLine();
            }

            if (parkingLot.Count>0)
            {
                foreach (var item in parkingLot)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
