using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string phoneNumbers=Console.ReadLine();
            string pattern = @"\+359(-? ?)2(-? ?)[0-9]{3}(-? ?)[0-9]{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches=regex.Matches(phoneNumbers);
            var matchedPhones = matches.Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
