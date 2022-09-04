using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string seriesString=Console.ReadLine();
            while (seriesString!="end")
            {
                char[] reversed=seriesString.Reverse().ToArray();
                Console.WriteLine($"{seriesString} = {string.Join("",reversed)}");
                seriesString = Console.ReadLine();
            }
        }
    }
}
