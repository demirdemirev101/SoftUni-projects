using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
           

            int count=int.Parse(Console.ReadLine());
            //for (int i = 0; i < count; i++)
            //{
            //    string[] chemicalCompounds=Console.ReadLine().Split().ToArray();
            //    for (int j = 0; j < chemicalCompounds.Length; j++)
            //    {
            //        set.Add(chemicalCompounds[j]);
            //    }

            //}
            for (int i = 0; i < count; i++)
            {
              string[] chemicalCompounds = Console.ReadLine().Split().ToArray();

             set.UnionWith(chemicalCompounds);
            }

            Console.WriteLine(String.Join(" ",set.OrderBy(x=>x)));
        }
    }
}
