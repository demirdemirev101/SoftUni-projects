using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> miligramsCaffeine=new Stack<int>(input1);

            int[] input2 = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> energyDrinks = new Queue<int>(input2);

            int totalCaffeine = 0;
            int caffeineInTheDrink = 0;

            while (miligramsCaffeine.Count!=0 && energyDrinks.Count!=0 )
            {
                int caffeine = miligramsCaffeine.Peek();
                int energyDrink=energyDrinks.Peek();

                 caffeineInTheDrink = caffeine * energyDrink;

                if (caffeineInTheDrink+totalCaffeine <= 300)
                {
                    miligramsCaffeine.Pop();
                    energyDrinks.Dequeue();

                    totalCaffeine += caffeineInTheDrink;
                }
                else 
                {
                    miligramsCaffeine.Pop();
                    int removedDrink=energyDrinks.Dequeue();
                    energyDrinks.Enqueue(removedDrink);

                    if (totalCaffeine-30>0)
                    {
                        totalCaffeine -= 30;
                    }

                }
            }
            if (energyDrinks.Count>0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ",energyDrinks)}");
               
            }
             else if (energyDrinks.Count==0)
             {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
             }
                Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");
        }
    }
}
