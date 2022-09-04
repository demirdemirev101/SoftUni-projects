using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int j = 0; j < integerList.Count; j++)
            {

                if (integerList[j] < 0)
                {
                    integerList.Remove(integerList[j]);
                    j = -1;
                }
            }
            integerList.Reverse();

            if (integerList.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < integerList.Count; i++)
                {
                    Console.Write($"{integerList[i]} ");
                }
            }
        }
    }
}
