using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            TypeOperation(operation, number1, number2);
        }
        static void TypeOperation(string operation, int number1, int number2)
        {
            if (operation == "add")
            {
                Add(number1, number2);
            }
            else if (operation == "substract")
            {
                Substract(number1, number2);
            }
            else if (operation == "divide")
            {
                Divide(number1, number2);
            }
            else if (operation == "multiply")
            {
                Multiply(number1, number2);
            }
        }
        static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        static void Substract(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        static void Divide(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
        static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }
}
