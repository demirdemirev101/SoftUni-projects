using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , string> parkingLot = new Dictionary<string, string>();
            int numberOfCommands=int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command=Console.ReadLine();
                string[] tokens=command.Split(' ');
                string username=tokens[1];
                if (tokens[0] =="register")
                {
                    if (!parkingLot.ContainsKey(username))
                    {
                        parkingLot.Add(username, tokens[2]);
                        Console.WriteLine($"{username} registered {tokens[2]} successfully");
                    }
                    else 
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {tokens[2]}");
                       
                    }
                }
                else  if (tokens[0]=="unregister")
                {
                    if(!parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else if (parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parkingLot.Remove(username);
                    }
               
                }

            }
            foreach (var item in parkingLot)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
