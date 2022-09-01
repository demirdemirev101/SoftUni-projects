using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();
            NumVowels(word);
        }
        static void NumVowels(string vowels)
        {
            int counterOfVowels = 0;
            foreach (char vowel in vowels)
            {
                if ("auoei".Contains(vowel))
                {
                    counterOfVowels++;
                }
            }
            Console.WriteLine(counterOfVowels);

        }
    }
}
