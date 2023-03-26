using System;
using System.Linq;

namespace SwapMethod
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            
            Swap<int> swap = new Swap<int>();
            for (int i = 0; i < n; i++)
            {
                int numbers=int.Parse(Console.ReadLine());
                swap.Items.Add(numbers);
            }
            int[] swapIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            swap.SwapIndexes(swapIndexes[0], swapIndexes[1]);
            
            Console.WriteLine(swap.ToString());
        }
    }
}