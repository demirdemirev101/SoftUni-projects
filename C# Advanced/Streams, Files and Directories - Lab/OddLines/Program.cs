using System;
using System.IO;

namespace OddLines
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
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = 0;
                using (var writer = new StreamWriter(outputFilePath))
                { 
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (counter++ %2==1)
                        {
                            writer.WriteLine(line);
                        }
                        
                    }
                }
            }
        }
    }
}

