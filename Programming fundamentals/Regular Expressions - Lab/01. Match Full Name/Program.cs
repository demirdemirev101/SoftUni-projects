﻿using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            string names=Console.ReadLine();
            
            string pattern=@"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex= new Regex(pattern);
            
            MatchCollection matchedNames = regex.Matches(names);

            Console.WriteLine(string.Join(" ", matchedNames));
        }
    }
}
