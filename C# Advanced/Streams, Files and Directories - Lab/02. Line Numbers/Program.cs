using System;
using System.IO;

namespace _02._Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var readinput = new StreamReader("../../../Input.txt");
            using (readinput)
            {
                int counter = 0;
                using (var output = new StreamWriter("../../../Output.txt"))
                {
                    while (true)
                    {
                        string[] line = readinput.ReadLine().Split(new string[] {".", ";"},StringSplitOptions.RemoveEmptyEntries);
                        
                        if (line == null)
                        {
                            break;
                        }
                        output.WriteLine(++counter + ". " + line);
                    }
                }
            }
        }
    }
}
