using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          StackOfStrings customStack=new StackOfStrings();
            customStack.AddRange(new List<string>() { "1","2","3","4" });
            customStack.AddRange(new List<string>() { "5","6","7","8" });
            while (!customStack.IsEmpty())
            {
                Console.WriteLine(customStack.Pop());
            }

        }
    }
}
