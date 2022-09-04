using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] stringInputs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string inputOne=stringInputs[0];
            string inputTwo=stringInputs[1];
            int sum = 0;
            
            if (inputOne.Length >= inputTwo.Length)
            {
                sum = InputOneIsLarger(inputOne,inputTwo);
            }
            else 
            {
               sum=InputTwoIsLarger(inputOne,inputTwo);
                
            }
            Console.WriteLine(sum);


        }
        public static int InputOneIsLarger(string inputOne, string inputTwo)
        {
            int sum = 0;
            int multiply = 0;
            for (int j = 0; j < inputOne.Length; j++)
            {
                if (j < inputTwo.Length)
                {
                    multiply = inputOne[j] * inputTwo[j];
                    sum += multiply;
                }
                else
                {

                    sum += inputOne[j];
                }

            }
            return sum;
        }
        public static int InputTwoIsLarger(string inputOne, string inputTwo)
        {
            int sum = 0;
            int multiply = 0;
            for (int i = 0; i < inputTwo.Length; i++)
            {

                if (i < inputOne.Length)
                {
                    multiply = inputOne[i] * inputTwo[i];
                    sum += multiply;
                }
                else
                {

                    sum += inputTwo[i];
                }


            }
            return sum;
        }
    }
}
