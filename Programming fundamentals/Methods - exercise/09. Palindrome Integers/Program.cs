using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            while (inputNumbers != "END")
            {
                bool isIntegerPalindrome = IsPalindrome(inputNumbers);
                Console.WriteLine(isIntegerPalindrome.ToString().ToLower());
                inputNumbers = Console.ReadLine();
            }

        }
        static bool IsPalindrome(string input)
        {
            int inputNumber = int.Parse(input);
            if (inputNumber >= 1 && inputNumber <= 9)
            {
                return true;
            }
            if (input[0] == input[input.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}
