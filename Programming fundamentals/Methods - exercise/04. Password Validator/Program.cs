using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();
            if (!Is6to10Characters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (!IsLetterOrDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsContainingTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool Is6to10Characters(string password)
        {
            int numCharacters = password.Length;
            if (numCharacters < 6 || numCharacters > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool IsLetterOrDigit(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }

            }
            return true;
        }
        static bool IsContainingTwoDigits(string password)
        {
            int counter = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
