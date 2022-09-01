using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int numbersOfRepeatingTheString = int.Parse(Console.ReadLine());
            string result = Repeatings(word, numbersOfRepeatingTheString);
            Console.WriteLine(result);
        }
        static string Repeatings(string str, int count)
        {
            string result = "";
            for (int i = 0; i < count - 1; i++)
            {
                result = str;
                Console.Write(result);
            }
            return result;
        }
    }
}
