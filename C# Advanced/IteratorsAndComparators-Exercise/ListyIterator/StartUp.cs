using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();
            ListyIterator<string> iterator=new ListyIterator<string>(items);

          string command=Console.ReadLine();
            while (command!="END")
            {  
                switch (command)
                {
                    case"HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case"Print":
                        try
                        {
                            iterator.Print();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;
                    case "PrintAll":
                        Console.WriteLine(String.Join(" ",iterator));
                        break;
                }
                command=Console.ReadLine();
            }
        }
    }
}