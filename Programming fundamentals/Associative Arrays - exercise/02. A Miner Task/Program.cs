using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Dictionary<string, ulong> dict=new Dictionary<string, ulong>();
            while(true)
            {
                string resource = Console.ReadLine();
                
                if (resource=="stop")
                {
                    break;
                }
                ulong price = ulong.Parse(Console.ReadLine());
                if (!dict.ContainsKey(resource))
                {
                
                    dict.Add(resource, price);
                }
                else
                {
                    dict[resource] += price;
                }

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
