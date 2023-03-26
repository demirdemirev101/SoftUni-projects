using System;
using System.IO;

namespace _01._Odd_Lines
{
    public class OddLines
    {
        static void Main() 
        { 
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt"; 
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        { // TODO: write your code here…
            var reader=new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = 1;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line==null)
                    {
                        break;
                    }
                    Console.WriteLine(counter+++". "+line);
                }
            }
        }
    }
}
