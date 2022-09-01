using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            for (int j = 0; j < arr2.Length; j++)
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[j])
                    {
                        continue;
                    }
                    Console.Write(arr2[j] + " "); ;

                }

        }
    }
}
