using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if (list.Count % 2 != 0)
            {


                for (int i = 0; i < list.Count / 2; i++)
                {
                    list[i] += list[list.Count - 1];

                    list.RemoveAt(list.Count - 1);

                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] += list[list.Count - 1];

                    list.RemoveAt(list.Count - 1);

                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
