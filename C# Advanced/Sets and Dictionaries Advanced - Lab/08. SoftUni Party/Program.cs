using System;
using System.Collections.Generic;


namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
           
         

            string input = Console.ReadLine();
            while (input.ToUpper()!= "PARTY")
            {
               
                if (input.Length==8)
                {
                    char c= input[0];

                    if (char.IsDigit(c))
                    {
                        if (!vip.Contains(input))
                        {
                         vip.Add(input);

                        }
                    }
                    else
                    {
                        if (!regular.Contains(input))
                        {
                            regular.Add(input);

                        }
                      
                    }

                }

                input = Console.ReadLine();
            }
            string input2=Console.ReadLine();
            while (input2.ToUpper()!="END")
            {
                if (regular.Contains(input2))
                {
                    regular.Remove(input2);
                }
                if (vip.Contains(input2))
                {
                    vip.Remove(input2);
                }
                input2 =Console.ReadLine();
            }
    
            Console.WriteLine(vip.Count+regular.Count);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item2 in regular)
            {
                Console.WriteLine(item2);
            }
        }
    }
}
