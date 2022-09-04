using System;
using System.Linq;
using System.Text;
namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
            char[] chars=input.ToCharArray();

            StringBuilder digits=new StringBuilder();
            StringBuilder letters=new StringBuilder();
            StringBuilder otherCharacters=new StringBuilder();
            foreach (var @char in chars)
            {
                if(char.IsDigit(@char))
                {
                    digits.Append(@char);
                    
                }
                else if(char.IsLetter(@char))
                {
                    letters.Append(@char);
                }
                else
                {
                    otherCharacters.Append(@char);
                }

            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherCharacters);
        }
    }
}
