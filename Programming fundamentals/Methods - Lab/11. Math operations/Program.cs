using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = 0;
            switch (@operator)
            {
                case "*":
                    result = MultiplyOperation(firstNumber, @operator, secondNumber);

                    break;
                case "/":
                    result = DivideOperation(firstNumber, @operator, secondNumber);
                    break;
                case "+":
                    result = SummaryOperation(firstNumber, @operator, secondNumber);
                    break;
                case "-":
                    result = SubstractOperation(firstNumber, @operator, secondNumber);
                    break;
            }
            Console.WriteLine(result);
        }
        static double DivideOperation(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0;

            result = firstNumber / secondNumber;

            return result;
        }
        static double MultiplyOperation(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0;
            result = firstNumber * secondNumber;
            return result;
        }
        static double SummaryOperation(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0;
            result = firstNumber + secondNumber;

            return result;
        }
        static double SubstractOperation(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0;
            result = firstNumber - secondNumber;

            return result;
        }
    }
}
