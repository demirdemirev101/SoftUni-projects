using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main() {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath); 
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
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
                        if (line==null)
                        {
                            break;
                        }
                            writer.WriteLine(++counter+". "+line);

                    }
                }
            }
        }
        
    }
    
}
