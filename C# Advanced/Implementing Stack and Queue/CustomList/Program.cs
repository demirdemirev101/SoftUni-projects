using System;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList list= new CustomList();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            var elem=list[1];
            Console.WriteLine(list.RemoveAt(1));
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]+" ");
            //}
            //Console.WriteLine();
            list.Insert(1, 6);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(list.Contains(6));
            list.Swap(0, 1);
            Console.WriteLine("After swap");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
