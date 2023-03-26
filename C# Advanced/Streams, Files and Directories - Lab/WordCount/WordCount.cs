using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt"; 
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        { // TODO: write your code here…
            SortedDictionary<string, int> specialWords = new SortedDictionary<string, int>();
             
            
            var words = File.ReadAllText(wordsFilePath).Split(new[] {" ","\r","\n"},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!specialWords.ContainsKey(words[i].ToLower()))
                {
                    specialWords.Add(words[i], 0);
                }

            }

          var text = File.ReadAllText(textFilePath).Split(new[] { " ", "\n", "?", "-", ",", ".","\r" }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < text.Length; j++)
            {
                if (specialWords.ContainsKey(text[j].ToLower()))
                {
                    specialWords[text[j].ToLower()]++;
                }
            }
            var orderedSpecialWords = specialWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var specialWord in orderedSpecialWords)
                {
                    writer.WriteLine($"{specialWord.Key} - {specialWord.Value}");
                }
            }
        }
    } 
}
