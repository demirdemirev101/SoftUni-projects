using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            string dates=Console.ReadLine();
            string pattern = @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matches=regex.Matches(dates);

            foreach (Match match in matches)
            {
                var day=match.Groups["day"].Value;
                var month=match.Groups["month"].Value;
                var year=match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
