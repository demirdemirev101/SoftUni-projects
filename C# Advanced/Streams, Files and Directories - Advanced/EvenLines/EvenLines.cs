
namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    public class EvenLines
    {

        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";
            
            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader streamReader = new StreamReader(inputFilePath);
            StringBuilder sb = new StringBuilder();
           
            
                int count = 0;
                string line = "";
                while (line != null)
                {
                    line = streamReader.ReadLine();
                    if (count % 2 == 0)
                    {

                    string[] symbolsToReplace = { "-", ",", ".", "!", "?" };

                    foreach (var symbol in symbolsToReplace)
                    {
                        line = line.Replace(symbol, "@");
                    }
                    //string replace = SymbolsToReplace(line).ToString();

                    
                    string[] reverse = line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .Reverse()
                             .ToArray();

                    string reverseToString = string.Join(" ", reverse);

                    sb.AppendLine(reverseToString);

                    }
                    count++;

                }
            
            return sb.ToString().TrimEnd();
        }
       
    }
}
