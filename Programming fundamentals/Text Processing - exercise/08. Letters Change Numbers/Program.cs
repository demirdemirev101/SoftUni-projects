using System;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
      
            string sequence1=sequence[0];

            //First sequence.
            StringBuilder stringNum1 = new StringBuilder();
            for (int i = 0; i < sequence1.Length; i++)
            {
                if (char.IsDigit(sequence1[i]))
                {
                    stringNum1.Append(new string(sequence1[i].ToString()));
                }
            }
            int number1 = int.Parse(stringNum1.ToString());
            for (int i = 0; i < sequence1.Length; i++)
            {
                char currentCharacter = sequence1[i];
                int position = (int)currentCharacter % 32;
                if (char.IsUpper(currentCharacter))
                {
                    number1 /= position;
                }
                else if (char.IsLower(currentCharacter))
                {
                    number1 += position;
                }
            }

            //Second sequence.
            if (sequence.Length >= 2)
            {
                string sequence2 = sequence[1];
                string sequence3 = sequence[2];

                StringBuilder stringNum2 = new StringBuilder();
                for (int j = 0; j < sequence2.Length; j++)
                {
                    if (char.IsDigit(sequence2[j]))
                    {
                        stringNum2.Append(new string(sequence2[j].ToString()));
                    }
                }
                int number2 = int.Parse(stringNum2.ToString());
                for (int k = 0; k < sequence2.Length; k++)
                {
                    char currentCharacter2 = sequence2[k];
                    int position2 = (int)currentCharacter2 % 32;
                    if (char.IsUpper(currentCharacter2))
                    {
                        number2 -= position2;
                    }
                    else if (char.IsLower(currentCharacter2))
                    {
                        number2 *= position2;
                    }
                }

                double finalResult = number1 + number2;
            Console.WriteLine($"{finalResult:f2}");
            }
            else
            {
                double finalResult = number1;
                Console.WriteLine($"{finalResult:f2}");
            }
        }
    }
}
