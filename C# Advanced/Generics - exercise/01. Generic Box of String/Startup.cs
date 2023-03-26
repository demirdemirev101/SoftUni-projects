using System;

namespace _01._Generic_Box_of_String
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Box<int> box = new Box<int>();
          
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                box.Items.Add(value);
            }
            Console.WriteLine(box.ToString());
        }
    }
}
