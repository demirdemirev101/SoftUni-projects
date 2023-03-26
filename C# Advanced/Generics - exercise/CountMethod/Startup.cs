using System;

namespace CountMethod
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CountMethod<string> counter = new CountMethod<string>();
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                counter.Items.Add(numbers);
            }
            string element = Console.ReadLine();

            Console.WriteLine(counter.Occurances(element));
        }
    }
}