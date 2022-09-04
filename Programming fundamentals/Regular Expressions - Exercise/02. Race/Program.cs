using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names=Console.ReadLine().Split().ToList();
            string patternName= @"(?<name>[A-Za-z])";
            string patternDistance= @"(?<distance>\d+)";

            List<string > list=new List<string>();  

            string input=Console.ReadLine();
            while (input!="end of race")
            {
                Regex regexName=new Regex(patternName);
                Regex regexDistance=new Regex(patternDistance);
                
                Match matchNames=regexName.Match(input);
                Match matchDistance=regexDistance.Match(input);
                if (matchNames.Success && matchDistance.Success)
                {
                    if (names.Contains(matchNames.Groups["name"].Value))
                    {
                        var name = matchNames.Groups["name"].Value;
                        var distance = int.Parse(matchDistance.Groups["distance"].Value);
                        distance += distance;
                        list.Add(name);
                    }
                }
                input=Console.ReadLine();
            }
        }
    }
}
