using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLenght = username.Length - 1;
            string password = "";
            int tryings = 0;
            for (int i = usernameLenght; i >= 0; i--)
            {
                password += username[i];
            }

            string inputPassword = Console.ReadLine();
            while (inputPassword != password)
            {
                tryings++;
                if (tryings == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();

            }
            if (inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}