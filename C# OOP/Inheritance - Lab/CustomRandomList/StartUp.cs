using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();
            random.Add("1");
            random.Add("2");
            random.Add("3");
            random.Add("4");
            Console.WriteLine(random.RandomString());

        }
    }
}
