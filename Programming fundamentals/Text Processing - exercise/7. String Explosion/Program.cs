using System;
using System.Text;

namespace _7._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result=new StringBuilder();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar=input[i];
                if (currentChar=='>')
                {
                    power += int.Parse(input[i+1].ToString());
                    result.Append(currentChar);
                }
                else if (power==0)
                {
                    result.Append(currentChar);
                }
                else
                {
                    power--;
                }
            }
        Console.WriteLine(result);
        }
    }
}
