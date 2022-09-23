using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int capacityOfTheRack=int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothesInTheBox);
            int sum = 0;
            int numOfRacks = 1;

            for (int i = 0; i < stack.Count; i++)
            {
                sum += stack.Peek();
                if (sum < capacityOfTheRack&& stack.Count!=0)
                {
                    stack.Pop();
                }
                 if (sum==capacityOfTheRack&&stack.Count!=0)
                {
                    stack.Pop();
                }
                else if (sum>capacityOfTheRack)
                {
                    sum = 0;
                     
                    numOfRacks++;
                    i -=1;
                }
                
            }
            
            Console.WriteLine(numOfRacks);
        }
    }
}
