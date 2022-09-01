using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());

            CharactersInRange(character1, character2);
        }
        static void CharactersInRange(char character1, char character2)
        {
            for (int i = character1; i < character2 - 1; i++)
            {
                Console.Write((char)(i + 1) + " ");
            }
        }
    }
}
